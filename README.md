# Base64 Clipboard Converter

## Overview

This tool converts an image from clipboard to Base64 format, suitable to be embedded in Markdown.

The implementation of such a tool requires some kind of desktop API support because clipboard is an operating system feature. On the other hand, the general conversion process can be done in just a CLI program.

## Usage

![image](https://github.com/chaojian-zhang/Base64ClipboardConverter/assets/7077098/d984df4c-5ec8-4de4-8d29-925002a0fa44)

1. Download from release page
2. Get image to clipboard in anyway you prefer
3. The image is displayed and converted **when application window is activated** while clipboard contains image data
4. Click "Copy" button to get the Base64 representation

## TODO

- [ ] Implement File menu to allow converting images from local files

## Technical Remarks

It's not as simple as `Clipboard.GetImage()` due to formatting issues. See:

* https://stackoverflow.com/questions/25749843/wpf-image-source-clipboard-getimage-is-not-displayed
* https://thomaslevesque.com/2009/02/05/wpf-paste-an-image-from-the-clipboard/

* Also see: https://weblog.west-wind.com/posts/2020/Sep/16/Retrieving-Images-from-the-Clipboard-and-WPF-Image-Control-Woes

## Additional References

Look at https://github.com/chaojian-zhang/ClipboardInspector for a Windows based tool to inspect clipboard (text) contents.
