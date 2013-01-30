namespace ElseIf
{
    public class SuperType : ICondition
    {
        public ICondition _condition;
        public void Accept(IVisitor visitor)
        {
            _condition.Accept(visitor);
        }
    }
}