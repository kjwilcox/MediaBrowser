﻿using MediaBrowser.Controller.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBrowser.Api.Reports
{
	/// <summary> A report header. </summary>
	public class ReportHeader
	{
		/// <summary> Initializes a new instance of the ReportHeader class. </summary>
		public ReportHeader()
		{
			ItemViewType = ItemViewType.None;
			Visible = true;
			CanGroup = true;
		}

		/// <summary> Gets or sets the type of the header field. </summary>
		/// <value> The type of the header field. </value>
		public ReportFieldType HeaderFieldType { get; set; }

		/// <summary> Gets or sets the name of the header. </summary>
		/// <value> The name of the header. </value>
		public string Name { get; set; }

		/// <summary> Gets or sets the name of the field. </summary>
		/// <value> The name of the field. </value>
		public HeaderMetadata FieldName { get; set; }

		/// <summary> Gets or sets the sort field. </summary>
		/// <value> The sort field. </value>
		public string SortField { get; set; }

		/// <summary> Gets or sets the type. </summary>
		/// <value> The type. </value>
		public string Type { get; set; }

		/// <summary> Gets or sets the type of the item view. </summary>
		/// <value> The type of the item view. </value>
		public ItemViewType ItemViewType { get; set; }

		/// <summary> Gets or sets a value indicating whether this object is visible. </summary>
		/// <value> true if visible, false if not. </value>
		public bool Visible { get; set; }

		/// <summary> Gets or sets a value indicating whether we can group. </summary>
		/// <value> true if we can group, false if not. </value>
		public bool CanGroup { get; set; }

	}
}
