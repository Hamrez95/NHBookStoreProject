using NHibernate.Cfg;
using System.Configuration;
using Configuration = NHibernate.Cfg.Configuration;

namespace NHConsole01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cfg = new Configuration().Configure();
            var sessionFactory = cfg.BuildSessionFactory();
        }
    }
}
