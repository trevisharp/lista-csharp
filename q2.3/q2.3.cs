// Explique em suas palavras a vantagem do
// find2 sobre o find1.

bool find1(Tree binaryTree, int value)
{
    if (binaryTree is null)
        return false;
    
    if (binaryTree.Value == value)
        return true;
    
    if (find1(binaryTree.Left, value))
        return true;
    
    if (find1(binaryTree.Right, value))
        return true;
    
    return false;
}

bool find2(Tree binaryTree, int value)
{
    if (binaryTree is null)
        return false;
    
    if (binaryTree.Value == value)
        return true;

    return binaryTree.Value > value ?
        find2(binaryTree.Left, value) :
        find2(binaryTree.Right, value);
}

public class Tree
{
    public int Value { get; set; }
    public Tree Left { get; set; }
    public Tree Right { get; set; }
}