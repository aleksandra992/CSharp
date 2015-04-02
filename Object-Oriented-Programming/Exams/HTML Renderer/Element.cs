namespace HTMLRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public class Element:IElement
    {
        private string name;
        private string textContent;
        private ICollection<IElement> childElements;

        public Element(string name,string textContent=null)
        {
            this.Name = name;
            this.TextContent = textContent;
            this.childElements = new List<IElement>();

        }
       

        public string Name
        {
            get { return this.name; }
            private set {
              
                this.name = value;
            }
        }

        public string TextContent
        {
           
            get
            {
               StringBuilder removedSpecials=new StringBuilder();
               foreach (var ch in this.textContent)
               {
                   if (ch == '>')
                   {
                       removedSpecials.Append("&gt");
                   }
                   else
                       if (ch == '<')
                       {
                           removedSpecials.Append("&lt");
                       }
                       else if (ch == '&')
                       {
                           removedSpecials.Append("&amp");

                       }
                       else
                           removedSpecials.Append(ch);
                   
               }
               return removedSpecials.ToString() ;
            }
            set
            {
                this.textContent = value;
            }
        }

        public IEnumerable<IElement> ChildElements
        {
            get { return new List<IElement>(this.childElements); }
        }



        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (this.childElements.Count == 0 && this.textContent==null)
            {
                output.Append(string.Format("<{0}></{1}>", this.Name,this.Name));
            }
            else
            if (this.childElements.Count==0 && this.textContent!=null)
            {
                output.Append(string.Format("<{0}><{1}></{2}>", this.Name,this.TextContent, this.Name));
            }
            else
                if (this.childElements.Count != 0 && this.textContent == null)
                {
                    output.Append(string.Format("<{0}><{1}></{2}>", this.Name,this.ChildElementsString(), this.Name));
                }
                else
            output.Append(string.Format("<{0}><{1}><{2}></{3}>",this.Name,this.textContent,this.ChildElements,this.Name));
        }

        public string ChildElementsString()
        {
            StringBuilder str = new StringBuilder();
            foreach (var childElement in this.childElements)
            {
                str.Append(childElement.ToString());
                
            }
            return str.ToString();
        }
        public override string ToString()
        {
            StringBuilder elementString = new StringBuilder();
            this.Render(elementString);
            return elementString.ToString();
        }


       
    }
}
