﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Winterdom.Viasfora.Languages.BraceExtractors;
using Winterdom.Viasfora.Languages.CommentParsers;
using Winterdom.Viasfora.Util;

namespace Winterdom.Viasfora.Languages {
  class Python : LanguageInfo {
    public const String ContentType = "Python";

    static readonly String[] KEYWORDS = {
          "break", "continue", "if", "elif", "else",
          "for", "raise", "return", "while", "yield"
      };
    static readonly String[] VIS_KEYWORDS = {
      };
    static readonly String[] LINQ_KEYWORDS = {
          "from", "in"
      };
    public override bool SupportsEscapeSeqs {
      get { return true; }
    }
    public override string BraceList {
      get { return "(){}[]"; }
    }
    protected override String[] ControlFlowDefaults {
      get { return KEYWORDS; }
    }
    protected override String[] LinqDefaults {
      get { return LINQ_KEYWORDS; }
    }
    protected override String[] VisibilityDefaults {
      get { return VIS_KEYWORDS; }
    }
    protected override String KeyName {
      get { return "Python"; }
    }
    public override IBraceExtractor NewBraceExtractor() {
      return new PythonBraceExtractor(this);
    }
    protected override String[] ContentTypes {
      get { return new String[] { ContentType }; }
    }
    public override IFirstLineCommentParser NewFirstLineCommentParser() {
      return new PythonFirstLineCommentParser();
    }
  }
}
