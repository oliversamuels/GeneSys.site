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
	/// <summary>About Page</summary>
	[PublishedModel("aboutPage")]
	public partial class AboutPage : PublishedContentModel, IAboutPageProperties, IHeaderProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		public new const string ModelTypeAlias = "aboutPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<AboutPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public AboutPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
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
		public virtual string AboutHead => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetAboutHead(this, _publishedValueFallback);

		///<summary>
		/// AboutIntroHeading: Main Header on the About Page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutIntroHeading")]
		public virtual string AboutIntroHeading => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetAboutIntroHeading(this, _publishedValueFallback);

		///<summary>
		/// AboutIntroIMG: Main Images
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutIntroIMG")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> AboutIntroImg => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetAboutIntroImg(this, _publishedValueFallback);

		///<summary>
		/// AboutIntroSubHeading: The Sub Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutIntroSubHeading")]
		public virtual string AboutIntroSubHeading => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetAboutIntroSubHeading(this, _publishedValueFallback);

		///<summary>
		/// AboutSubHead
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutSubHead")]
		public virtual string AboutSubHead => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetAboutSubHead(this, _publishedValueFallback);

		///<summary>
		/// ChallengeContent: Section Contect Textarea
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("challengeContent")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString ChallengeContent => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetChallengeContent(this, _publishedValueFallback);

		///<summary>
		/// ChallengeHeader: Section Header Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("challengeHeader")]
		public virtual string ChallengeHeader => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetChallengeHeader(this, _publishedValueFallback);

		///<summary>
		/// FirstImg: First Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FirstImg => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetFirstImg(this, _publishedValueFallback);

		///<summary>
		/// GalleryIMGs: Images
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("galleryIMGs")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> GalleryImgs => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetGalleryImgs(this, _publishedValueFallback);

		///<summary>
		/// GalleryTitle: Heading for the Gallery section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("galleryTitle")]
		public virtual string GalleryTitle => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetGalleryTitle(this, _publishedValueFallback);

		///<summary>
		/// MilestoneTitle: Section Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("milestoneTitle")]
		public virtual string MilestoneTitle => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetMilestoneTitle(this, _publishedValueFallback);

		///<summary>
		/// Mission: Company's Mission
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mission")]
		public virtual string Mission => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetMission(this, _publishedValueFallback);

		///<summary>
		/// PersonnelList: List of available personnels
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("personnelList")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockGridModel PersonnelList => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetPersonnelList(this, _publishedValueFallback);

		///<summary>
		/// PersonnelSectionHeading: Section Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("personnelSectionHeading")]
		public virtual string PersonnelSectionHeading => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetPersonnelSectionHeading(this, _publishedValueFallback);

		///<summary>
		/// SecondImg: Second Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("secondImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SecondImg => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetSecondImg(this, _publishedValueFallback);

		///<summary>
		/// Vision: Company's Vision
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("vision")]
		public virtual string Vision => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetVision(this, _publishedValueFallback);

		///<summary>
		/// WhoWeAre: Who we are content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("whoWeAre")]
		public virtual string WhoWeAre => global::Umbraco.Cms.Web.Common.PublishedModels.AboutPageProperties.GetWhoWeAre(this, _publishedValueFallback);

		///<summary>
		/// Title: Enter a title for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.1.0+bad9148")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("title")]
		public virtual string Title => global::Umbraco.Cms.Web.Common.PublishedModels.HeaderProperties.GetTitle(this, _publishedValueFallback);
	}
}
