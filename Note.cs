using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON
{
    class Note
    {
        private String mAuthor;
        private String mText;
        private int mImportance;

        public Note() { this.mAuthor = "Unknown"; this.mText = "Empty"; this.mImportance = 0; }
        public Note(String author, String text) { this.mAuthor = author; this.mText = text; this.mImportance = 0; }
        public Note(String author, String text, int importance) { this.mAuthor = author; this.mText = text; this.mImportance = importance; }

        public String Author
        {
            get { return this.mAuthor; }
        }
        public String Text
        {
            get { return this.mText; }
            set { this.mText = value; }
        }
        public int Importance
        {
            get { return this.mImportance; }
            set { this.mImportance = value; }
        }
        public String getAuthor()
        {
            return this.mAuthor;
        }
        public String getText()
        {
            return this.mText;
        }
        public void setText(String text)
        {
            this.mText = text;
        }
        public int getImportance()
        {
            return this.mImportance;
        }
        public void setImportance(int importance)
        {
            this.mImportance = importance;
        }
        public override string ToString()
        {
            return "Author: " + this.mAuthor + "\n" + "Text: " + this.mText + "\n" + "Importance: " + this.mImportance;
        }
    }
}
