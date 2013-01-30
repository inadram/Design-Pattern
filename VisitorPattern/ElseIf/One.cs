namespace ElseIf
{
    public class One:ICondition
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}