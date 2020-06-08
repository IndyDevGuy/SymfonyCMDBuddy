using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymfonyCMDBuddy
{
    public class Profile
    {
        public string name;
        public string documentRoot;
        public string SymfonyVersion;

        private bool active;

        private int profileNumber;

        public string setName(string name)
        {
            this.name = name;
            return this.name;
        }

        public string getName()
        {
            return this.name;
        }

        public string setDocumentRoot(string documentRoot)
        {
            this.documentRoot = documentRoot;
            return this.documentRoot;
        }

        public string getDocumentRoot()
        {
            return this.documentRoot;
        }

        public string setSymfonyVersion(string SymfonyVersion)
        {
            this.SymfonyVersion = SymfonyVersion;
            return this.SymfonyVersion;
        }

        public string getSymfonyVersion()
        {
            return this.SymfonyVersion;
        }

        public bool setActive(bool active)
        {
            this.active = active;
            return this.active;
        }

        public bool getActive()
        {
            return this.active;
        }

        public int setProfileNumber(int profileNumber)
        {
            this.profileNumber = profileNumber;
            return this.profileNumber;
        }

        public int getProfileNumber()
        {
            return this.profileNumber;
        }
    }
}
