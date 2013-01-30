namespace ElseIf
{
    public class Two:ICondition
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}