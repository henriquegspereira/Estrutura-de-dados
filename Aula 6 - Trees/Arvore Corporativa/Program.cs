using Arvore_Corporativa;

Tree<Person> company = new Tree<Person>();
company.Root = new TreeNode<Person>()
{
    Data = new Person(100, "Jamro", "CEO"),
    Parent = null
};
company.Root.Children = new List<TreeNode<Person>>
{
    new TreeNode<Person>()
    {
        Data = new Person(1, "Smith", "Head of Development"),
        Parent = company.Root,
    },
    new TreeNode<Person>()
    {
        Data = new Person(50, "Fox", "Head of Research"),
        Parent = company.Root,
    },
    new TreeNode<Person>()
    {
        Data = new Person(150, "Lily", "Head of Sales"),
        Parent = company.Root,
    },
};
company.Root.Children[2].Children = new List<TreeNode<Person>>
{
    new TreeNode<Person>()
    {
        Data = new Person(30, "Black", "Sales Specialist"),
        Parent = company.Root.Children[2]
    },
};
