namespace NARKSpawn
{
    internal class CatType2
    {
        public string Name { get; set; }
        public string ParentCat { get; set; }
        public string ParentType { get; set; }

        public CatType2()
        {
        }

        public CatType2(string name, string parentCat, string parentType)
        {
            Name = name;
            ParentCat = parentCat;
            ParentType = parentType;
        }
    }
}