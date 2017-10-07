namespace NARKSpawn
{
    internal class CatType
    {
        public string Name { get; set; }
        public string ParentCat { get; set; }

        public CatType()
        {
        }

        public CatType(string name, string parentCat)
        {
            Name = name;
            ParentCat = parentCat;
        }
    }
}