//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v11.1.0+bad9148
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "aboutPageProperties"
	/// <summary>About Page Properties</summary>
	public partial interface IAboutPageProperties : IPublishedElement
	{
		/// <summary>AboutHead</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string AboutHead { get; }

		/// <summary>AboutIntroHeading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string AboutIntroHeading { get; }

		/// <summary>AboutIntroIMG</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> AboutIntroImg { get; }

		/// <summary>AboutIntroSubHeading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string AboutIntroSubHeading { get; }

		/// <summary>AboutSubHead</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string AboutSubHead { get; }

		/// <summary>ChallengeContent</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Strings.IHtmlEncodedString ChallengeContent { get; }

		/// <summary>ChallengeHeader</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string ChallengeHeader { get; }

		/// <summary>ChallengeImg</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.MediaWithCrops ChallengeImg { get; }

		/// <summary>FirstImg</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.MediaWithCrops FirstImg { get; }

		/// <summary>GalleryIMGs</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> GalleryImgs { get; }

		/// <summary>GalleryTitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string GalleryTitle { get; }

		/// <summary>Mission</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Mission { get; }

		/// <summary>SecondImg</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.MediaWithCrops SecondImg { get; }

		/// <summary>Vision</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Vision { get; }

		/// <summary>WhoWeAre</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string WhoWeAre { get; }
	}

	/// <summary>About Page Properties</summary>
	[PublishedModel("aboutPageProperties")]
	public partial class AboutPageProperties : PublishedElementModel, IAboutPageProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		public new const string ModelTypeAlias = "aboutPageProperties";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<AboutPageProperties, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public AboutPageProperties(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// AboutHead
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutHead")]
		public virtual string AboutHead => GetAboutHead(this, _publishedValueFallback);

		/// <summary>Static getter for AboutHead</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetAboutHead(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "aboutHead");

		///<summary>
		/// AboutIntroHeading: Main Header on the About Page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutIntroHeading")]
		public virtual string AboutIntroHeading => GetAboutIntroHeading(this, _publishedValueFallback);

		/// <summary>Static getter for AboutIntroHeading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetAboutIntroHeading(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "aboutIntroHeading");

		///<summary>
		/// AboutIntroIMG: Main Images
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutIntroIMG")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> AboutIntroImg => GetAboutIntroImg(this, _publishedValueFallback);

		/// <summary>Static getter for AboutIntroIMG</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> GetAboutIntroImg(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops>>(publishedValueFallback, "aboutIntroIMG");

		///<summary>
		/// AboutIntroSubHeading: The Sub Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutIntroSubHeading")]
		public virtual string AboutIntroSubHeading => GetAboutIntroSubHeading(this, _publishedValueFallback);

		/// <summary>Static getter for AboutIntroSubHeading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetAboutIntroSubHeading(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "aboutIntroSubHeading");

		///<summary>
		/// AboutSubHead
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutSubHead")]
		public virtual string AboutSubHead => GetAboutSubHead(this, _publishedValueFallback);

		/// <summary>Static getter for AboutSubHead</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetAboutSubHead(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "aboutSubHead");

		///<summary>
		/// ChallengeContent: Section Contect Textarea
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("challengeContent")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString ChallengeContent => GetChallengeContent(this, _publishedValueFallback);

		/// <summary>Static getter for ChallengeContent</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Strings.IHtmlEncodedString GetChallengeContent(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(publishedValueFallback, "challengeContent");

		///<summary>
		/// ChallengeHeader: Section Header Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("challengeHeader")]
		public virtual string ChallengeHeader => GetChallengeHeader(this, _publishedValueFallback);

		/// <summary>Static getter for ChallengeHeader</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetChallengeHeader(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "challengeHeader");

		///<summary>
		/// ChallengeImg: Challenge section Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("challengeImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ChallengeImg => GetChallengeImg(this, _publishedValueFallback);

		/// <summary>Static getter for ChallengeImg</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.MediaWithCrops GetChallengeImg(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(publishedValueFallback, "challengeImg");

		///<summary>
		/// FirstImg: First Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FirstImg => GetFirstImg(this, _publishedValueFallback);

		/// <summary>Static getter for FirstImg</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.MediaWithCrops GetFirstImg(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(publishedValueFallback, "firstImg");

		///<summary>
		/// GalleryIMGs: Images
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("galleryIMGs")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> GalleryImgs => GetGalleryImgs(this, _publishedValueFallback);

		/// <summary>Static getter for GalleryIMGs</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> GetGalleryImgs(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops>>(publishedValueFallback, "galleryIMGs");

		///<summary>
		/// GalleryTitle: Heading for the Gallery section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("galleryTitle")]
		public virtual string GalleryTitle => GetGalleryTitle(this, _publishedValueFallback);

		/// <summary>Static getter for GalleryTitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetGalleryTitle(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "galleryTitle");

		///<summary>
		/// Mission: Company's Mission
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mission")]
		public virtual string Mission => GetMission(this, _publishedValueFallback);

		/// <summary>Static getter for Mission</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetMission(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "mission");

		///<summary>
		/// SecondImg: Second Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("secondImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SecondImg => GetSecondImg(this, _publishedValueFallback);

		/// <summary>Static getter for SecondImg</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.MediaWithCrops GetSecondImg(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(publishedValueFallback, "secondImg");

		///<summary>
		/// Vision: Company's Vision
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("vision")]
		public virtual string Vision => GetVision(this, _publishedValueFallback);

		/// <summary>Static getter for Vision</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetVision(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "vision");

		///<summary>
		/// WhoWeAre: Who we are content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("whoWeAre")]
		public virtual string WhoWeAre => GetWhoWeAre(this, _publishedValueFallback);

		/// <summary>Static getter for WhoWeAre</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetWhoWeAre(IAboutPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "whoWeAre");
	}
}
