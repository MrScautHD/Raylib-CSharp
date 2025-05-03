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

# 🔧 **Advanced Renderer** 🚀
Discover the powerful features of our **✨new✨ Render Framework, [Bliss](https://github.com/MrScautHD/Bliss)**. 

<p align="right" style="margin-bottom: 0px !important;">
  <img width="512" src="https://github.com/user-attachments/assets/cb8a5929-3f79-4a68-ab2c-36b395148c06" alt="Logo" align="right">
</p>

Bliss is a **modern rendering solution** supporting:
- 🎮 **Direct3D11**
- 🌋 **Vulkan**
- 🖼️ **OpenGL**
- 🍎 **Metal**
- 📱 **OpenGL-ES**

Unlock advanced rendering capabilities with [Bliss](https://github.com/MrScautHD/Bliss) today!

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
[<img src="https://github.com/user-attachments/assets/f8b66880-9037-4ba8-acc4-6ea390e1dde9" alt="windows" width="70" height="70" align="left">](https://www.microsoft.com/de-at/windows)
### Windows
- Graphics APIs: `OpenGL-4.3`

[<img src="https://github.com/user-attachments/assets/814ce8c3-5242-47f4-a51b-b185680d38ff" alt="Linux" width="70" height="70" align="left">](https://www.ubuntu.com/)
### Linux
- Graphics APIs: `OpenGL-4.3`

[<img src="https://github.com/user-attachments/assets/99605868-0590-42ce-a72a-f6feb1cabf6e" alt="macOS" width="70" height="70" align="left">](https://www.apple.com/at/macos/sonoma/)
### MacOS
- Graphics APIs: `OpenGL-3.3`

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
