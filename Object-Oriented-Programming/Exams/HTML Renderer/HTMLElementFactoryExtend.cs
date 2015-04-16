namespace HTMLRenderer
{
    using System;
    public class HTMLElementFactoryExtend:IElementFactory
    {
        public IElement CreateElement(string name)
        {
            IElement element = new Element(name);
            return element;

        }
        public  IElement CreateElement(string name, string content)
        {
            IElement element = new Element(name, content);
          return element;
            
        }

        public ITable CreateTable(int rows, int cols)
        {
            ITable table = new Table(rows, cols);
            return table;
           
        }
    }

}
