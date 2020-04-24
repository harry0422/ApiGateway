using System;

namespace ApiGateway.CrossCutting.Transactions
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TransactionAttribute : Attribute
    {

    }
}