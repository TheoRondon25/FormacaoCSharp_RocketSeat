using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Domain.Secutiry.Cryptography;
public interface IPasswordEncripter
{
    string Encrypt(string password);
}
