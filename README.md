# Base64 Clipboard Converter

This tool converts an image from clipboard to Base64 format, suitable to be embedded in Markdown.

The implementation of such a tool requires some kind of desktop API support because clipboard is an operating system feature. On the other hand, the general conversion process can be done in just a CLI program.

It's not as simple as `Clipboard.GetImage()` due to formatting issues. See:

* https://stackoverflow.com/questions/25749843/wpf-image-source-clipboard-getimage-is-not-displayed
* https://thomaslevesque.com/2009/02/05/wpf-paste-an-image-from-the-clipboard/

* Also see: https://weblog.west-wind.com/posts/2020/Sep/16/Retrieving-Images-from-the-Clipboard-and-WPF-Image-Control-Woes