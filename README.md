<p align="center" style="margin-bottom: 0px !important;">
  <img width="512" src="https://github.com/MrScautHD/Raylib-CSharp/assets/65916181/6b01ab20-dbb1-40fc-a19f-acd7ae30c738" alt="Logo" align="center">
</p>

# Raylib-CSharp 🚀
[![Discord](https://img.shields.io/discord/1199798541980283051?style=flat-square&logo=discord&label=Discord)](https://discord.gg/7XKw6YQa76)
[![License](https://img.shields.io/github/license/MrScautHD/Raylib-CSharp?style=flat-square&logo=libreofficewriter&label=License)](LICENSE)
[![Activity](https://img.shields.io/github/commit-activity/w/MrScautHD/Raylib-CSharp?style=flat-square&logo=Github&label=Activity)](https://github.com/MrScautHD/Raylib-CSharp/activity)
[![Stars](https://img.shields.io/github/stars/MrScautHD/Raylib-CSharp?style=flat-square&logo=Github&label=Stars)](https://github.com/MrScautHD/Raylib-CSharp/stargazers)

__Raylib-CSharp__ is a fully managed binding over `Raylib-5.5`.

---

# 🪙 Installation - [Nuget](https://www.nuget.org/packages/Raylib-CSharp)
```
dotnet add package Raylib-CSharp --version 4.1.9
```

# 📖 [Installation - From source]
> 1. Clone this repository.
> 2. Add `Raylib-CSharp.csproj` as a reference to your project.
> 3. Ensure that you integrate the [`CMake.props`](https://github.com/MrScautHD/Raylib-CSharp/blob/main/src/Raylib-CSharp.Test/CMake.props) file into your project setup to facilitate the building process for the .dlls.
---

# 💻 Platforms
[<img src="https://github.com/MrScautHD/Sparkle/assets/65916181/a92bd5fa-517b-44c2-ab58-cc01b5ae5751" alt="windows" width="70" height="70" align="right">](https://www.microsoft.com/de-at/windows)
### Windows
- Using `OpenGL-4.3`

[<img src="https://github.com/MrScautHD/Sparkle/assets/65916181/f9e643a8-4d46-450c-91ac-d220394ecd42" alt="Linux" width="70" height="70" align="right">](https://www.ubuntu.com/)
### Linux
- Using `OpenGL-4.3`

[<img src="https://github.com/MrScautHD/Sparkle/assets/65916181/e37eb15f-4237-47ae-9ae7-e4455f7c3d92" alt="macOS" width="70" height="70" align="right">](https://www.apple.com/at/macos/sonoma/)
### MacOS
- Using `OpenGL-3.3`

# 🧑 Contributors
<a href="https://github.com/mrscauthd/Raylib-CSharp/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=mrscauthd/Raylib-CSharp&max=500&columns=20&anon=1" />
</a>

# ✉️ Reach us
[<img src="https://github.com/MrScautHD/Sparkle/assets/65916181/87b291cd-6506-4fb5-b032-abf3170a28c4" alt="discord" width="186" height="60">](https://discord.gg/7XKw6YQa76)
[<img src="https://github.com/MrScautHD/Sparkle/assets/65916181/de09f016-db11-4554-aa56-4d1bd6c2464f" alt="sponsor" width="186" height="60">](https://github.com/sponsors/MrScautHD)

---

# 📖 Differences from [`Raylib-cs`](https://github.com/ChrisDill/Raylib-cs)

| Raylib-cs                                                            | `Raylib-CSharp`                                                                                                                                                                   |
| -------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| One Binding Class (`Raylib.cs`).                                     | Managed Classes like `Window, Music...`.                                                                                                                                          |
| Uses `DllImport` and makes using pointers `required` in some cases.  | Uses `LibraryImport` and using pointers is `optional`.                                                                                                                            |
| Using one `Namespace`.                                               | Using multiple `Namespaces`!                                                                                                                                                      |
| .NET 5.0, 6.0 / C# 10                                                | .NET 8.0 / C# 12                                                                                                                                                                  |
| Released 2018-07                                                     | Released 2024-05                                                                                                                                                                  |
| License ZLib                                                         | License MIT                                                                                                                                                                       |
| Raylib 5.0                                                           | Raylib 5.1-dev                                                                                                                                                                    |

# ✍️ Acknowledgement
This library is available under the [MIT](https://choosealicense.com/licenses/mit) license.

Special thanks to the author(s) and contributors of the following projects
* [Raylib](https://github.com/raysan5/raylib)
