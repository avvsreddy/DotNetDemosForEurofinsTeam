using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDELab
{
    class Program
    {
        static void Main(string[] args)
        {
            IDE ide = new IDE();
            LangJava java = new LangJava();
            ide.Languages.Add(java);
            LangCSharp cs = new LangCSharp();
            ide.Languages.Add(cs);
            LangC c = new LangC();
            ide.Languages.Add(c);
            VBNet vb = new VBNet();
            ide.Languages.Add(vb);
            Pascal p = new Pascal();
            //ide.Languages.Add(p);
            SmallTalk sm = new SmallTalk();
            ide.Languages.Add(sm);

            //ide.Languages.Remove(p);

            ide.WorkWithLanguages();


        }
    }

    class IDE
    {
        public List<ILanguage> Languages { get; set; } = new List<ILanguage>();

        public void WorkWithLanguages()
        {
            foreach (var lang in Languages)
            {
                Console.WriteLine(lang.GetName());
                Console.WriteLine(lang.GetUnit());
                Console.WriteLine(lang.GetParadigm());
            }
        }
    }

    interface ILanguage
    {
        string GetName();
        string GetUnit();
        string GetParadigm();
    }

    abstract class OOLanguage : ILanguage
    {
        public string GetUnit() { return "Class"; }
        public string GetParadigm() { return "Object Oriented"; }

        abstract public string GetName();
        
    }

    abstract class ProcLanguage : ILanguage
    {
        public string GetUnit() { return "Function"; }
        public string GetParadigm() { return "Procedure Oriented"; }

        abstract public string GetName();
       
    }

    class LangJava : OOLanguage
    {
        public override string GetName() { return "Java"; }
        
    }

    class LangCSharp : OOLanguage
    {
        public override string GetName() { return "C Sharp"; }
      
    }

    class VBNet : OOLanguage
    {
        public override string GetName() { return "VB.Net"; }

    }
    class LangC : ProcLanguage
    {
        public override string GetName() { return "C Language"; }
       
    }

    class Pascal : ProcLanguage
    {
        public override string GetName() { return "Pascal"; }
       
    }

    class SmallTalk : OOLanguage
    {
        public override string GetName()
        {
            return "Small Talk";
        }
    }
}
