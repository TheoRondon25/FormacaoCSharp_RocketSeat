using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Secutiry.Token;
public interface IAccessTokenGenerator
{
    string Generate(User user);
}
