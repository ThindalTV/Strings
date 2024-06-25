# Thindal.Strings

Thindal.Strings is a project that provides various string manipulation utilities and extensions.

## Features

- String SubstringOrShorter
- String Until

## Installation

To use Thindal.Strings in your project, download and compile the source code or get the latest release from Nuget.

## Usage

Since Thindal.Strings are in the ```System``` namespace, you don't need to add any using directive beyond ```using System;``` to use them.

### String SubstringOrShorter

SubstringOrShorter is a combination of String.IndexOf and String.Substring that returns a substring from the start of the string to the requested length, or the full string if the string is shorter.
Usage is the same as Substring but with the suffix OrShorter on the method name.

### String Until

Until is a method that returns a substring from the start of the string to the first occurrence of a specified character.
Usage is the same as IndexOf, but instead it returns a string up until the specified character.

## Contributing

Contributions to Thindal.Strings are welcome! If you find a bug or have a feature request, please open an issue on the [GitHub repository](https://github.com/ThindalTV/Strings). Pull requests are also appreciated.

## License

Thindal.Strings is released under the [MIT License](https://opensource.org/licenses/MIT).
