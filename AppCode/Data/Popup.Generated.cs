// DO NOT MODIFY THIS FILE - IT IS AUTO-GENERATED
// See also: https://go.2sxc.org/copilot-data
// To extend it, create a "Popup.cs" with this contents:
/*
namespace AppCode.Data
{
  public partial class Popup
  {
    // Add your own properties and methods here
  }
}
*/

// Generator:   CSharpDataModelsGenerator v17.06.02
// App/Edition: Pop-Up Message/
// User:        2sic Web-Developer
// When:        2024-04-05 09:43:19Z
using ToSic.Sxc.Adam;

namespace AppCode.Data
{
  // This is a generated class for Popup 
  // To extend/modify it, see instructions above.

  /// <summary>
  /// Popup data. <br/>
  /// Generated 2024-04-05 09:43:19Z. Re-generate whenever you change the ContentType. <br/>
  /// <br/>
  /// Default properties such as `.Title` or `.Id` are provided in the base class. <br/>
  /// Most properties have a simple access, such as `.Image`. <br/>
  /// For other properties or uses, use methods such as
  /// .IsNotEmpty("FieldName"), .String("FieldName"), .Children(...), .Picture(...), .Html(...).
  /// </summary>
  public partial class Popup: AutoGenerated.ZagPopup
  {  }
}

namespace AppCode.Data.AutoGenerated
{
  /// <summary>
  /// Auto-Generated base class for Default.Popup in separate namespace and special name to avoid accidental use.
  /// </summary>
  public abstract class ZagPopup: Custom.Data.CustomItem
  {
    /// <summary>
    /// Image as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("Image")
    /// </summary>
    public string Image => _item.Url("Image");

    /// <summary>
    /// Get the file object for Image - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile ImageFile => _item.File("Image");

    /// <summary>
    /// Get the folder object for Image.
    /// </summary>
    public IFolder ImageFolder => _item.Folder("Image");

    /// <summary>
    /// Link as link (url). <br/>
    /// To get the underlying value like 'file:72' use String("Link")
    /// </summary>
    public string Link => _item.Url("Link");

    /// <summary>
    /// Get the file object for Link - or null if it's empty or not referencing a file.
    /// </summary>
    public IFile LinkFile => _item.File("Link");

    /// <summary>
    /// Get the folder object for Link.
    /// </summary>
    public IFolder LinkFolder => _item.Folder("Link");

    /// <summary>
    /// LinkNewTab as bool. <br/>
    /// To get nullable use .Get("LinkNewTab") as bool?;
    /// </summary>
    public bool LinkNewTab => _item.Bool("LinkNewTab");

    /// <summary>
    /// LinkText as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("LinkText", scrubHtml: true) etc.
    /// </summary>
    public string LinkText => _item.String("LinkText", fallback: "");

    /// <summary>
    /// Text as string. <br/>
    /// For advanced manipulation like scrubHtml, use .String("Text", scrubHtml: true) etc.
    /// </summary>
    public string Text => _item.String("Text", fallback: "");
  }
}