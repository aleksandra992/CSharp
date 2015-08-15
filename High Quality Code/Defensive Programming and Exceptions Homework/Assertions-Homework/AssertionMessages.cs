using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assertions_Homework
{
    public static class AssertionValidationMessages
    {
        public const string ArrayLengthCannotBeZero = "{0} must have at least one element";
        public const string ValueCannotBeNull = "{0} cannot be null";
        public const string InvalidResultArrayLength = "{0} must have the same lenght as the original array";
        public const string IndexMustBeBetweenTwoIndexes = "The {0} index must be between 0 and the length of the array";
        public const string IndexMustBeBeforeAnotherIndex = "The {0} index must be before the {1} index or at least same as the {1} index";
          }
}
