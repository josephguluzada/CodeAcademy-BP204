namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deagle deagle = new Deagle();
            deagle.BulletCapacity = 7;
            deagle.BulletCount = 5;
            deagle.Reload();
            deagle.Shoot();

            Ak47 ak47 = new();
            ak47.BulletCapacity = 30;
            ak47.BulletCount = 22;
            ak47.Reload();
            ak47.Shoot();
            ak47.Fire();

            Glock18 glock18 = new();
            glock18.BulletCapacity = 20;
            glock18.BulletCount = 12;
            glock18.Reload();
            glock18.Shoot();
            glock18.Fire();

        }
    }
}