using UnityEngine;

public class BinarySearchTree : MonoBehaviour
{
    public class TreeNode // ��ø Ŭ����
    {
        public TreeNode left;
        public TreeNode right;
        public int value;

        public TreeNode(int value)
        {
            this.value = value;
        }
    }

    private TreeNode root;
    private int[] array = { 8, 3, 10, 1, 6, 14, 4, 7, 13 }; // ������ �׳� �迭

    private string result;

    private void Start()
    {
        foreach (var v in array) // v : ��忡 �� ����
        {
            root = Insert(root, v);
        }   
    }

    private TreeNode Insert(TreeNode node, int v)
    {
        if (node == null)
        {
            return new TreeNode(v);
        }

        if (v < node.value)
        {
            node.left = Insert(node.left, v);
        }
        else
        {
            node.right = Insert(node.right, v);
        }

        return node;
    }
}
