<image src="app-icon.png" align="right" width="200px">

# Popup 3 App for .net CMSs

> This is a [2sxc](https://2sxc.org) App for [DNN ☢️](https://www.dnnsoftware.com/) and [Oqtane 💧](https://www.oqtane.org/)

A standard popup message app to use with 2sxc.

| Aspect              | Status | Comments or Version
| ------------------- | :----: | -------------------
| 2sxc                | ✅    | requires 2sxc v17.07.00
| Dnn                 | ✅    | For v9.6.1+
| Oqtane              | ✅    | Requires v05.00+
| No jQuery           | ✅    |
| Live Demo           | ➖    |
| Install Checklist   | ✅    | See [Installation](https://azing.org/2sxc/r/hTIJS1Vg) on [azing.org](https://azing.org/2sxc)
| Source & License    | ✅    | included, ISC/MIT
| App Catalog         | ✅    | See [app catalog](https://2sxc.org/en/apps/app/popup-v3-hybrid-for-dnn-and-oqtane)
| Screenshots         | ✅    | See [app catalog](https://2sxc.org/en/apps/app/popup-v3-hybrid-for-dnn-and-oqtane)
| Best Practices      | ✅    | Uses v13.10 conventions
| Bootstrap 3         | ✔️    | Works well, but not optimized
| Bootstrap 4         | ✅    |
| Bootstrap 5         | ✅    |

## Customize the App

The Popup app does not have any app settings but two app resources(labels) you can customize.

If you want to customize the CSS, you will usually follow the ["Create Custom Styles in a Standard 2sxc App" checklist](https://azing.org/2sxc/r/gg_aB9FD)

## History

* v.03.00 2021-10
  * Updated to 2sxc 12.05 standard
  * Now hybrid - works with Oqtane
  * No more jQuery
* v.03.02 2022-04
  * Moved all access of Services to ToSic.Sxc.Services
  * Changed all images to use latest Picture-tag technology
  * Enabled the image configuration
  * Replaced data-enableoptimizations with pageSvc.AssetAttributes()
* v.03.03 2022-06 
  * Replaced all base classes with their 2sxc 14 equivalents
  * Removed all GetService<> and used ServiceKit14
  * Updated webpack
* v.03.04 2023-02
  * Replaced Tag.Custom with `Kit.HtmlTags`
  * Replaced turnOn Tag with `Kit.Page.TurnOn`
  * Removed _ from Filenames
  * Code in one file the bs5, less duplicated code
* v03.05.00 2023-07
  * 2sxc 16.02 coding conventions
  * everything typed
* v03.17.00 2024-04
  * strong typed
  * Auto Generated Class
* v03.17.01 2024-07
  * Update app.sln and app.csproj
* v03.21.00 2026-03
  * Added intellisense Extensions for Visual Studio Code
* v03.21.01 2026-06
  * Switched from webpack to Vite for faster builds 
  