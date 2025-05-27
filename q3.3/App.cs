using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System;

public static class App
{
    public static void Run()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        StarFinder hearth = new StarFinder();

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
            List<Star> stars = [];
            for (int i = 0; i < 100; i++)
                stars.Add(new Star {
                    Brightness = Random.Shared.NextSingle() / 2,
                    X = 400 * Random.Shared.NextSingle(),
                    Y = 400 * Random.Shared.NextSingle()
                });

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
                        var brightness = 255 * hearth.GetBrightness(i, j, stars);
                        var color = (byte)float.Clamp(brightness, 0, 255);
                        l[0] = color;
                        l[1] = color;
                        l[2] = color;
                    }
                }
            }

            back.UnlockBits(data);
            pb.Image = back;
        }
    }
}