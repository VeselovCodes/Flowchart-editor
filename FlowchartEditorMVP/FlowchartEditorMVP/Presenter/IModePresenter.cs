﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowchartEditorMVP.Presenter
{
    interface IModePresenter : IPresenter
    {
    }

    class ModePresenter : IModePresenter
    {
        public void Run() { }
    }
}
