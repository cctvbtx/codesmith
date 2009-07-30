﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

using CodeSmith.Engine;
using CodeSmith.SchemaHelper;

using Configuration=CodeSmith.SchemaHelper.Configuration;

namespace QuickStart
{
    public class CSLABaseTemplate : CodeTemplate
    {
        #region Constructor(s)

        public CSLABaseTemplate()
        {
            ResolveTargetLanguage();
            TemplateContext = new Dictionary<string, string>();
        }

        #endregion

        #region Public Properties

        [Browsable(false)]
        public Dictionary<string, string> TemplateContext { get; set; }

        #endregion

        #region Private Method(s)

        private void ResolveTargetLanguage()
        {
            if (CodeTemplateInfo != null)
            {
                if (CodeTemplateInfo.TargetLanguage.ToUpper() == "VB")
                {
                    Configuration.Instance.TargetLanguage = LanguageEnum.VB;
                }
                else
                {
                    Configuration.Instance.TargetLanguage = LanguageEnum.CSharp;
                }
            }
        }

        #endregion

        #region Public Method(s)

        public virtual void RegisterReferences()
        {
            RegisterReference(Path.GetFullPath(Path.Combine(CodeTemplateInfo.DirectoryName, @"..\..\Common\Csla\Csla.dll")));
        }

        #endregion
    }
}
