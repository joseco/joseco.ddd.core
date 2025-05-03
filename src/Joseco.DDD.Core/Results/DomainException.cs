using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joseco.DDD.Core.Results;

public class DomainException(Error Error) : Exception
{
    public Error Error { get; } = Error;
}