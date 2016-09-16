using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex01_Michael_305597478_Shai_300518495
{
    public interface IFacebookAction
    {
        void InvokeAction();

        bool IsConditionSatisfied();
    }
}
