﻿using NecroNet.SharePoint.CodeCaml.Elements.Base;
using NecroNet.SharePoint.CodeCaml.Enums;

namespace NecroNet.SharePoint.CodeCaml.Elements
{
	public class CQTodayElement : CQElement
	{
		[CQAttribute]
		public int? Offset { get; set; }

		public CQTodayElement()
		{
		}

		public CQTodayElement(int offset)
		{
			Offset = offset;
		}

		protected override CQTag Tag
		{
			get { return CQTag.Today; }
		}
	}
}
