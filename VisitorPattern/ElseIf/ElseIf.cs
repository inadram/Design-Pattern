namespace ElseIf
{
    public class ElseIf
    {
        public string Factory(ICondition condition)
        {
            SuperType superType = new SuperType();
            superType._condition = condition;
            GetStatus getStatus=new GetStatus();
            superType.Accept(getStatus);

            return getStatus.status;
        }
    }
}
