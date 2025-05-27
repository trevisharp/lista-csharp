using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

public static class App
{
    public static void Run()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        HeartDrawer hearth = new HeartDrawer();

        var form = new Form {
            WindowState = FormWindowState.Maximized,
            FormBorderStyle = FormBorderStyle.None
        };

        form.KeyDown += (o, e) =>
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        };

        var pb = new PictureBox {
            SizeMode = PictureBoxSizeMode.Zoom,
            Dock = DockStyle.Fill
        };
        form.Controls.Add(pb);

        form.Load += (o, e) => process();

        Application.Run(form);

        void process()
        {
            var back = new Bitmap(400, 400);

            var data = back.LockBits(
                new Rectangle(0, 0, back.Width, back.Height),
                ImageLockMode.ReadWrite, 
                PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* p = (byte*)data.Scan0.ToPointer();

                byte[] tempB = new byte[data.Width];
                byte[] tempG = new byte[data.Width];
                byte[] tempR = new byte[data.Width];

                for (int j = 0; j < data.Height; j++)
                {
                    byte* l = p + j * data.Stride;
                    for (int i = 0; i < data.Width; i++, l += 3)
                    {
                        var pixels = hearth.SetPixels(i, j);
                        l[0] = pixels[0];
                        l[1] = pixels[1];
                        l[2] = pixels[2];
                    }
                }
            }

            back.UnlockBits(data);
            pb.Image = back;
        }
    }
}