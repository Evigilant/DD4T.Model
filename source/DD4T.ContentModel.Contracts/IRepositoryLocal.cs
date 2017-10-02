﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DD4T.ContentModel
{
    public interface IRepositoryLocal : IItem
    {
        IPublication Publication { get; }
        IPublication OwningPublication { get; }
    }
}
