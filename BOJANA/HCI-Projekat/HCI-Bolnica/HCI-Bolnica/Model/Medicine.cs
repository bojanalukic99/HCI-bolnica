using HCIBolnica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Bolnica.Model
{
   public  class Medicine : Entity
    {
        private String name;
        private String grams;
        private String composition; 
        private String comment;
        private String replacement;
        private bool isCertified;

        public bool IsCertified
        {
            get { return isCertified; }
            set
            {
                isCertified = value;
                OnPropertyChanged(nameof(IsCertified));
            }
        }
        public Medicine(String name)
        {
            Name=name;
        }

        public Medicine()
        { }

        public Medicine(String name, String grams, String composition, String comment, String replacement)
        {
            Name = name;
            Grams = grams;
            Composition = composition;
            Comment = comment;
            Replacment = replacement;
        }
        public String Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public String Grams 
        {
            get { return grams; }
            set
            {
                grams = value;
                OnPropertyChanged(nameof(Grams));
            }
        }
        public String Composition
        {
            get { return composition; }
            set 
            {
                composition = value;
                OnPropertyChanged(nameof(Composition));
            }
        }
        public String Comment
        {
            get { return comment; }
            set
            {
                comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }
        public String Replacment
        {
            get { return replacement; }
            set
            {
                replacement = value;
                OnPropertyChanged(nameof(Replacment));
            }

        }
        public override string Validate(string columName)
        {
            return "";
        }
        public override void InitExportList()
        {

        }
    }
}
