namespace ElseIf
{
    public class GetStatus:IVisitor
    {
        public string status = string.Empty;
        public void Visit(One one)
        {
            status = "This is class one type";
        }

        public void Visit(Two two)
        {
            status = "This is class two type";
        }
    }
}