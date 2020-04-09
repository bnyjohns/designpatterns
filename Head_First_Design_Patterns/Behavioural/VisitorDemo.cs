using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_First_Design_Patterns.VisitorDemo
{
    class VisitorDemo
    {
        //static void Main()
        //{
        //    Document textBook = new TextBook("Hello");
        //    Document noteBook = new NoteBook("Hello");
        //    IVisitor htmlWriteVisitor = new HTMLWriteVisitor();
        //    IVisitor germanWriteVisitor = new GermanWriteVisitor();
        //    textBook.Accept(htmlWriteVisitor);
        //    textBook.Accept(germanWriteVisitor);
        //    noteBook.Accept(germanWriteVisitor);

        //    //If you want to write Russian, you dont have to change NoteBook or TextBook.
        //    //Just need to create a new writevisitor class and make the documents accept them.
        //}
    }

    interface IVisitable
    {
        void Accept(IVisitor visitor);
    }

    interface IVisitor
    {
        void VisitNoteBook(Document document);
        void VisitTextBook(Document document);
    }

    class HTMLWriteVisitor : IVisitor
    {
        public void VisitNoteBook(Document document)
        {
            Console.WriteLine("NoteBook:<html>" + document.Text + "</html>");
        }

        public void VisitTextBook(Document document)
        {
            Console.WriteLine("TextBook:<html>" + document.Text + "</html>");
        }
    }

    class GermanWriteVisitor : IVisitor
    {
        public void VisitNoteBook(Document document)
        {
            Console.WriteLine("NoteBook:<German>" + document.Text + "</German>");
        }

        public void VisitTextBook(Document document)
        {
            Console.WriteLine("TextBook:<German>" + document.Text + "</German>");
        }
    }

    abstract class Document : IVisitable
    {
        public string Text { get; set; }

        //public abstract void WriteAsHTML();

        public abstract void Accept(IVisitor visitor);        
    }

    class NoteBook : Document
    {
        //public override void WriteAsHTML()
        //{
        //    throw new NotImplementedException();
        //}

        public NoteBook(string text)
        {
            Text = text;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitNoteBook(this);
        }
    }

    class TextBook : Document
    {
        //public override void WriteAsHTML()
        //{
        //    throw new NotImplementedException();
        //}

        public TextBook(string text)
        {
            Text = text;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitTextBook(this);
        }
    }

}
