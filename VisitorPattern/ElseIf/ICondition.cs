namespace ElseIf
{
    public interface ICondition
    {
        void Accept(IVisitor visitor);
    }
}