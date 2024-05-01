<p align="center">
  <img alt="Logo" src="https://github.com/MrScautHD/Raylib-CSharp/assets/72702101/f798360f-5c61-4b0b-b028-41b36c094fba)" />
</p>

<h1 align="center" style="margin-top: 0px;">Welcome to the Raylib-CSharp Wiki 🎉</h1>
<h4 align="center">This wiki is dedicated to all things in Raylib-CSharp. Explore our documentation and guides to get started!</h4>

## Raylib
```cs
void TakeScreenshot(string fileName);                 // Takes a screenshot of current screen (filename extension defines format)
void SetConfigFlags(ConfigFlag flags);                // Setup init configuration flags (view FLAGS)
void OpenURL(string url);                             // Open URL with default system browser (if available)

void SetRandomSeed(uint seed);                         // Set the seed for the random number generator
int GetRandomValue(int min, int max);                 // Get a random value between min and max (both included)
int* LoadRandomSequence(int count, int min, int max); // Load random values sequence, no values repeated
void UnloadRandomSequence(int* sequence);             // Unload random values sequence

void* MemAlloc(int size);                             // Internal memory allocator
void* MemRealloc(void* ptr, int size);                // Internal memory reallocator
void MemFree(void* ptr);                              // Internal memory free
```

## Window
```cs 
void Init(int width, int height, string title);       // Initialize window and OpenGL context
void Close();                                         // Close window and unload OpenGL context
bool ShouldClose();                                   // Check if application should close (KEY_ESCAPE pressed or windows close icon clicked)
bool IsReady();                                       // Check if window has been initialized successfully
bool IsFullscreen();                                  // Check if window is currently fullscreen
bool IsHidden();                                      // Check if window is currently hidden (only PLATFORM_DESKTOP)
bool IsMinimized();                                   // Check if window is currently minimized (only PLATFORM_DESKTOP)
bool IsMaximized();                                   // Check if window is currently maximized (only PLATFORM_DESKTOP)
bool IsFocused();                                     // Check if window is currently focused (only PLATFORM_DESKTOP)
bool IsResized();                                     // Check if window has been resized last frame
bool IsState(ConfigFlag flag);                        // Check if one specific window flag is enabled
void SetState(ConfigFlag flags);                      // Set window configuration state using flags (only PLATFORM_DESKTOP)
void ClearState(ConfigFlag flags);                    // Clear window configuration state flags
void ToggleFullscreen();                              // Toggle window state: fullscreen/windowed (only PLATFORM_DESKTOP)
void ToggleBorderless();                              // Toggle window state: borderless windowed (only PLATFORM_DESKTOP)
void Maximize();                                      // Set window state: maximized, if resizable (only PLATFORM_DESKTOP)
void Minimize();                                      // Set window state: minimized, if resizable (only PLATFORM_DESKTOP)
void Restore();                                       // Set window state: not minimized/maximized (only PLATFORM_DESKTOP)
void SetIcon(Image image);                            // Set icon for window (single image, RGBA 32bit, only PLATFORM_DESKTOP)
void SetIcons(Image* images, int count);              // Set icon for window (multiple images, RGBA 32bit, only PLATFORM_DESKTOP)
void SetTitle(string title);                          // Set title for window (only PLATFORM_DESKTOP and PLATFORM_WEB)
void SetPosition(int x, int y);                       // Set window position on screen (only PLATFORM_DESKTOP)
void SetMonitor(int monitor);                         // Set monitor for the current window
void SetMinSize(int width, int height);               // Set window minimum dimensions (for FLAG_WINDOW_RESIZABLE)
void SetMaxSize(int width, int height);               // Set window maximum dimensions (for FLAG_WINDOW_RESIZABLE)
void SetSize(int width, int height);                  // Set window dimensions
void SetOpacity(float opacity);                       // Set window opacity [0.0f..1.0f] (only PLATFORM_DESKTOP)
void SetFocused();                                    // Set window focused (only PLATFORM_DESKTOP)
void* GetHandle();                                    // Get native window handle
int GetScreenWidth();                                 // Get current screen width
int GetScreenHeight();                                // Get current screen height
int GetRenderWidth();                                 // Get current render width (it considers HiDPI)
int GetRenderHeight();                                // Get current render height (it considers HiDPI)
int GetMonitorCount();                                // Get number of connected monitors
int GetCurrentMonitor();                              // Get current connected monitor
Vector2 GetMonitorPosition(int monitor);              // Get specified monitor position
int GetMonitorWidth(int monitor);                     // Get specified monitor width (current video mode used by monitor)
int GetMonitorHeight(int monitor);                    // Get specified monitor height (current video mode used by monitor)
int GetMonitorPhysicalWidth(int monitor);             // Get specified monitor physical width in millimetres
int GetMonitorPhysicalHeight(int monitor);            // Get specified monitor physical height in millimetres
int GetMonitorRefreshRate(int monitor);               // Get specified monitor refresh rate
Vector2 GetPosition();                                // Get window position XY on monitor
Vector2 GetScaleDPI();                                // Get window scale DPI factor
string GetMonitorName(int monitor);                   // Get the human-readable, UTF-8 encoded name of the specified monitor
void SetClipboardText(string text);                   // Set clipboard text content
string GetClipboardText();                            // Get clipboard text content
void EnableEventWaiting();                            // Enable waiting for events on EndDrawing(), no automatic event polling
void DisableEventWaiting();                           // Disable waiting for events on EndDrawing(), automatic events polling
```

## Graphics
```cs
void ClearBackground(Color color);                    // Set background color (framebuffer clear color)
void BeginDrawing();                                  // Setup canvas (framebuffer) to start drawing
void EndDrawing();                                    // End canvas drawing and swap buffers (double buffering)
void BeginMode2D(Camera2D camera);                    // Begin 2D mode with custom camera (2D)
void EndMode2D();                                     // Ends 2D mode with custom camera
void BeginMode3D(Camera3D camera);                    // Begin 3D mode with custom camera (3D)
void EndMode3D();                                     // Ends 3D mode and returns to default 2D orthographic mode
void BeginTextureMode(RenderTexture2D target);        // Begin drawing to render texture
void EndTextureMode();                                // Ends drawing to render texture
void BeginShaderMode(Shader shader);                  // Begin custom shader drawing
void EndShaderMode();                                 // End custom shader drawing (use default shader)
void BeginBlendMode(BlendMode mode);                  // Begin blending mode (alpha, additive, multiplied, subtract, custom)
void EndBlendMode();                                  // End blending mode (reset to default: alpha blending)
void BeginScissorMode(int x, int y, int width, int height);     // Begin scissor mode (define screen area for following drawing)
void EndScissorMode();                                // End scissor mode
void BeginVrStereoMode(VrStereoConfig config);        // Begin stereo rendering (requires VR simulator)
void EndVrStereoMode();                               // End stereo rendering (requires VR simulator)
void SwapScreenBuffer();                              // Swap back buffer with front buffer (screen drawing)
```

## VrManager
```cs
VrStereoConfig LoadStereoConfig(VrDeviceInfo device);  // Load VR stereo config for VR simulator device parameters
void UnloadStereoConfig(VrStereoConfig config);        // Unload VR stereo config
```

## ShaderManager
```cs
Shader LoadShader(string vsFileName, string fsFileName);    // Load shader from files and bind default locations
Shader LoadShaderFromMemory(string vsCode, string fsCode);  // Load shader from code strings and bind default locations
bool IsShaderReady(Shader shader);                          // Check if a shader is ready
int GetShaderLocation(Shader shader, string uniformName);   // Get shader uniform location
int GetShaderLocationAttrib(Shader shader, string attribName);    // Get shader attribute location
void SetShaderValue<T>(Shader shader, int locIndex, T value, ShaderUniformDataType uniformType);       // Set shader uniform value
void SetShaderValueV<T>(Shader shader, int locIndex, T[] value, ShaderUniformDataType uniformType);    // Set shader uniform value vector
void SetShaderValueMatrix(Shader shader, int locIndex, Matrix4x4 mat);        // Set shader uniform value (matrix 4x4)
void SetShaderValueTexture(Shader shader, int locIndex, Texture2D texture);   // Set shader uniform value for texture (sampler2d)
void UnloadShader(Shader shader);                           // Unload shader from GPU memory (VRAM)
```

## CameraManager
```cs
void UpdateCamera(ref Camera3D camera, CameraMode mode);                                     // Update camera position for selected mode
void UpdateCameraPro(ref Camera3D camera, Vector3 movement, Vector3 rotation, float zoom);   // Update camera movement/rotation

Ray GetMouseRay(Vector2 mousePosition, Camera3D camera);                               // Get a ray trace from mouse position
Matrix4x4 GetCameraMatrix(Camera3D camera);                                                  // Get camera transform matrix (view matrix)
Matrix4x4 GetCameraMatrix2D(Camera2D camera);                                                // Get camera 2d transform matrix
Vector2 GetWorldToScreen(Vector3 position, Camera3D camera);                           // Get the screen space position for a 3d world space position
Vector2 GetScreenToWorld2D(Vector2 position, Camera2D camera);                         // Get the world space position for a 2d camera screen space position
Vector2 GetWorldToScreenEx(Vector3 position, Camera3D camera, int width, int height);  // Get size position for a 3d world space position
Vector2 GetWorldToScreen2D(Vector2 position, Camera2D camera);                         // Get the screen space position for a 2d camera world space position
```

## Input
```cs
void ShowCursor();                                    // Shows cursor
void HideCursor();                                    // Hides cursor
bool IsCursorHidden();                                // Check if cursor is not visible
void EnableCursor();                                  // Enables cursor (unlock cursor)
void DisableCursor();                                 // Disables cursor (lock cursor)
bool IsCursorOnScreen();                              // Check if cursor is on the screen

bool IsKeyPressed(KeyboardKey key);                   // Check if a key has been pressed once
bool IsKeyPressedRepeat(KeyboardKey key);             // Check if a key has been pressed again (Only PLATFORM_DESKTOP)
bool IsKeyDown(KeyboardKey key);                      // Check if a key is being pressed
bool IsKeyReleased(KeyboardKey key);                  // Check if a key has been released once
bool IsKeyUp(KeyboardKey key);                        // Check if a key is NOT being pressed
KeyboardKey GetKeyPressed();                          // Get key pressed (keycode), call it multiple times for keys queued, returns 0 when the queue is empty
int GetCharPressed();                                 // Get char pressed (unicode), call it multiple times for chars queued, returns 0 when the queue is empty
void SetExitKey(KeyboardKey key);                     // Set a custom key to exit program (default is ESC)

bool IsGamepadAvailable(int gamepad);                 // Check if a gamepad is available
string GetGamepadName(int gamepad);                   // Get gamepad internal name id
bool IsGamepadButtonPressed(int gamepad, GamepadButton button);    // Check if a gamepad button has been pressed once
bool IsGamepadButtonDown(int gamepad, GamepadButton button);       // Check if a gamepad button is being pressed
bool IsGamepadButtonReleased(int gamepad, GamepadButton button);   // Check if a gamepad button has been released once
bool IsGamepadButtonUp(int gamepad, GamepadButton button);         // Check if a gamepad button is NOT being pressed
int GetGamepadButtonPressed();                        // Get the last gamepad button pressed
int GetGamepadAxisCount(int gamepad);                 // Get gamepad axis count for a gamepad
float GetGamepadAxisMovement(int gamepad, int axis);  // Get axis movement value for a gamepad axis
int SetGamepadMappings(string mappings);              // Set internal gamepad mappings (SDL_GameControllerDB)

bool IsMouseButtonPressed(MouseButton button);        // Check if a mouse button has been pressed once
bool IsMouseButtonDown(MouseButton button);           // Check if a mouse button is being pressed
bool IsMouseButtonReleased(MouseButton button);       // Check if a mouse button has been released once
bool IsMouseButtonUp(MouseButton button);             // Check if a mouse button is NOT being pressed
int GetMouseX();                                      // Get mouse position X
int GetMouseY();                                      // Get mouse position Y
Vector2 GetMousePosition();                           // Get mouse position XY
Vector2 GetMouseDelta();                              // Get mouse delta between frames
void SetMousePosition(int x, int y);                  // Set mouse position XY
void SetMouseOffset(int offsetX, int offsetY);        // Set mouse offset
void SetMouseScale(float scaleX, float scaleY);       // Set mouse scaling
float GetMouseWheelMove();                            // Get mouse wheel movement for X or Y, whichever is larger
Vector2 GetMouseWheelMoveV();                         // Get mouse wheel movement for both X and Y
void SetMouseCursor(MouseCursor cursor);              // Set mouse cursor

int GetTouchX();                                      // Get touch position X for touch point 0 (relative to screen size)
int GetTouchY();                                      // Get touch position Y for touch point 0 (relative to screen size)
Vector2 GetTouchPosition(int index);                  // Get touch position XY for a touch point index (relative to screen size)
int GetTouchPointId(int index);                       // Get touch point identifier for given index
int GetTouchPointCount();                             // Get number of touch points

void PollInputEvents();                               // Register all input events
```

## Time
```cs
void SetTargetFPS(int fps);                           // Set target FPS (maximum)
float GetFrameTime();                                 // Get time in seconds for last frame drawn (delta time)
double GetTime();                                     // Get elapsed time in seconds since InitWindow()
int GetFPS();                                         // Get current FPS
void WaitTime(double seconds);                        // Wait for some time (halt program execution)
```

## Logger
```cs
void Init();                                          // Initialize logger (custom logger)
void TraceLog(TraceLogLevel logLevel, string text);   // Show trace log messages (LOG_DEBUG, LOG_INFO, LOG_WARNING, LOG_ERROR...)
void SetTraceLogLevel(TraceLogLevel logLevel);        // Set the current threshold (minimum) log level
```

## FileManager
```cs
byte* LoadFileData(string fileName, uint* dataSize);   // Load file data as byte array (read)
void UnloadFileData(byte* data);                      // Unload file data allocated by LoadFileData()
bool SaveFileData(string fileName, void* data, uint dataSize);         // Save data to file from byte array (write), returns true on success
bool ExportDataAsCode(byte* data, uint dataSize, string fileName);     // Export data to code (.h), returns true on success
string LoadFileText(string fileName);                 // Load text data from file (read), returns a '\0' terminated string
void UnloadFileText(string text);                     // Unload file text data allocated by LoadFileText()
bool SaveFileText(string fileName, string text);      // Save text data to file (write), string must be '\0' terminated, returns true on success
bool FileExists(string fileName);                     // Check if file exists
bool DirectoryExists(string dirPath);                 // Check if a directory path exists
bool IsFileExtension(string fileName, string ext);    // Check file extension (including point: .png, .wav)
int GetFileLength(string fileName);                   // Get file length in bytes (NOTE: GetFileSize() conflicts with windows.h)
string GetFileExtension(string fileName);             // Get pointer to extension for a filename string (includes dot: '.png')
string GetFileName(string filePath);                  // Get pointer to filename for a path string
string GetFileNameWithoutExt(string filePath);        // Get filename string without extension (uses static string)
string GetDirectoryPath(string filePath);             // Get full path for a given fileName with path (uses static string)
string GetPrevDirectoryPath(string dirPath);          // Get previous directory path for a given path (uses static string)
string GetWorkingDirectory();                         // Get current working directory (uses static string)
string GetApplicationDirectory();                     // Get the directory of the running application (uses static string)
bool ChangeDirectory(string dir);                     // Change working directory, return true on success
bool IsPathFile(string path);                         // Check if a given path is a file or a directory
FilePathList LoadDirectoryFiles(string dirPath);      // Load directory filepaths
FilePathList LoadDirectoryFilesEx(string basePath, string filter, bool scanSubdirs);    // Load directory filepaths with extension filtering and recursive directory scan
void UnloadDirectoryFiles(FilePathList files);        // Unload filepaths
bool IsFileDropped();                                 // Check if a file has been dropped into window
FilePathList LoadDroppedFiles();                      // Load dropped filepaths
void UnloadDroppedFiles(FilePathList files);          // Unload dropped filepaths
long GetFileModTime(string fileName);                 // Get file modification time (last write time)

byte* CompressData(byte* data, int dataSize, int* compDataSize);          // Compress data (DEFLATE algorithm), memory must be MemFree()
byte* DecompressData(byte* compData, int compDataSize, int* dataSize);    // Decompress data (DEFLATE algorithm), memory must be MemFree()
string EncodeDataBase64(byte* data, int dataSize, int* outputSize);       // Encode data to Base64 string, memory must be MemFree()
byte* DecodeDataBase64(byte* data, int* outputSize);                      // Decode Base64 string data, memory must be MemFree()
```

## AutomationManager
```cs
AutomationEventList LoadAutomationEventList(string fileName);                  // Load automation events list from file, NULL for empty list, capacity = MAX_AUTOMATION_EVENTS
void UnloadAutomationEventList(ref AutomationEventList list);                  // Unload automation events list from file
bool ExportAutomationEventList(AutomationEventList list, string fileName);     // Export automation events list as text file
void SetAutomationEventList(ref AutomationEventList list);                     // Set automation event list to record to
void SetAutomationEventBaseFrame(int frame);                                   // Set automation event internal base frame to start recording
void StartAutomationEventRecording();                                          // Start recording automation events (AutomationEventList must be set)
void StopAutomationEventRecording();                                           // Stop recording automation events
void PlayAutomationEvent(AutomationEvent automationEvent);                     // Play a recorded automation event
```

## ShapeManager
```cs
void SetShapesTexture(Texture2D texture, Rectangle source);                                        // Set texture and rectangle to be used on shapes drawing

void DrawPixel(int posX, int posY, Color color);                                                   // Draw a pixel
void DrawPixelV(Vector2 position, Color color);                                                    // Draw a pixel (Vector version)
void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color);                // Draw a line
void DrawLineV(Vector2 startPos, Vector2 endPos, Color color);                                     // Draw a line (using gl lines)
void DrawLineEx(Vector2 startPos, Vector2 endPos, float thick, Color color);                       // Draw a line (using triangles/quads)
void DrawLineStrip(Vector2* points, int pointCount, Color color);                                  // Draw lines sequence (using gl lines)
void DrawLineBezier(Vector2 startPos, Vector2 endPos, float thick, Color color);                   // Draw line segment cubic-bezier in-out interpolation
void DrawCircle(int centerX, int centerY, float radius, Color color);                              // Draw a color-filled circle
void DrawCircleSector(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);    // Draw a piece of a circle
void DrawCircleSectorLines(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);     // Draw circle sector outline
void DrawCircleGradient(int centerX, int centerY, float radius, Color color1, Color color2);       // Draw a gradient-filled circle
void DrawCircleV(Vector2 center, float radius, Color color);                                       // Draw a color-filled circle (Vector version)
void DrawCircleLines(int centerX, int centerY, float radius, Color color);                         // Draw circle outline
void DrawCircleLinesV(Vector2 center, float radius, Color color);                                  // Draw circle outline (Vector version)
void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Color color);             // Draw ellipse
void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Color color);        // Draw ellipse outline
void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);         // Draw ring
void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);    // Draw ring outline
void DrawRectangle(int posX, int posY, int width, int height, Color color);                        // Draw a color-filled rectangle
void DrawRectangleV(Vector2 position, Vector2 size, Color color);                                  // Draw a color-filled rectangle (Vector version)
void DrawRectangleRec(Rectangle rec, Color color);                                                 // Draw a color-filled rectangle
void DrawRectanglePro(Rectangle rec, Vector2 origin, float rotation, Color color);                 // Draw a color-filled rectangle with pro parameters
void DrawRectangleGradientV(int posX, int posY, int width, int height, Color color1, Color color2);// Draw a vertical-gradient-filled rectangle
void DrawRectangleGradientH(int posX, int posY, int width, int height, Color color1, Color color2);// Draw a horizontal-gradient-filled rectangle
void DrawRectangleGradientEx(Rectangle rec, Color col1, Color col2, Color col3, Color col4);       // Draw a gradient-filled rectangle with custom vertex colors
void DrawRectangleLines(int posX, int posY, int width, int height, Color color);                   // Draw rectangle outline
void DrawRectangleLinesEx(Rectangle rec, float lineThick, Color color);                            // Draw rectangle outline with extended parameters
void DrawRectangleRounded(Rectangle rec, float roundness, int segments, Color color);              // Draw rectangle with rounded edges
void DrawRectangleRoundedLines(Rectangle rec, float roundness, int segments, float lineThick, Color color);     // Draw rectangle with rounded edges outline
void DrawTriangle(Vector2 v1, Vector2 v2, Vector2 v3, Color color);                                // Draw a color-filled triangle (vertex in counter-clockwise order!)
void DrawTriangleLines(Vector2 v1, Vector2 v2, Vector2 v3, Color color);                           // Draw triangle outline (vertex in counter-clockwise order!)
void DrawTriangleFan(Vector2* points, int pointCount, Color color);                                // Draw a triangle fan defined by points (first vertex is the center)
void DrawTriangleStrip(Vector2* points, int pointCount, Color color);                              // Draw a triangle strip defined by points
void DrawPoly(Vector2 center, int sides, float radius, float rotation, Color color);               // Draw a regular polygon (Vector version)
void DrawPolyLines(Vector2 center, int sides, float radius, float rotation, Color color);          // Draw a polygon outline of n sides
void DrawPolyLinesEx(Vector2 center, int sides, float radius, float rotation, float lineThick, Color color);    // Draw a polygon outline of n sides with extended parameters

void DrawSplineLinear(Vector2* points, int pointCount, float thick, Color color);                  // Draw spline: Linear, minimum 2 points
void DrawSplineBasis(Vector2* points, int pointCount, float thick, Color color);                   // Draw spline: B-Spline, minimum 4 points
void DrawSplineCatmullRom(Vector2* points, int pointCount, float thick, Color color);              // Draw spline: Catmull-Rom, minimum 4 points
void DrawSplineBezierQuadratic(Vector2* points, int pointCount, float thick, Color color);         // Draw spline: Quadratic Bezier, minimum 3 points (1 control point): [p1, c2, p3, c4...]
void DrawSplineBezierCubic(Vector2* points, int pointCount, float thick, Color color);             // Draw spline: Cubic Bezier, minimum 4 points (2 control points): [p1, c2, c3, p4, c5, c6...]
void DrawSplineSegmentLinear(Vector2 p1, Vector2 p2, float thick, Color color);                    // Draw spline segment: Linear, 2 points
void DrawSplineSegmentBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color);         // Draw spline segment: B-Spline, 4 points
void DrawSplineSegmentCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color);    // Draw spline segment: Catmull-Rom, 4 points
void DrawSplineSegmentBezierQuadratic(Vector2 p1, Vector2 c2, Vector2 p3, float thick, Color color);           // Draw spline segment: Quadratic Bezier, 2 points, 1 control point
void DrawSplineSegmentBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float thick, Color color);   // Draw spline segment: Cubic Bezier, 2 points, 2 control points

Vector2 GetSplinePointLinear(Vector2 startPos, Vector2 endPos, float t);                           // Get (evaluate) spline point: Linear
Vector2 GetSplinePointBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);              // Get (evaluate) spline point: B-Spline
Vector2 GetSplinePointCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);         // Get (evaluate) spline point: Catmull-Rom
Vector2 GetSplinePointBezierQuad(Vector2 p1, Vector2 c2, Vector2 p3, float t);                     // Get (evaluate) spline point: Quadratic Bezier
Vector2 GetSplinePointBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float t);        // Get (evaluate) spline point: Cubic Bezier

bool CheckCollisionRecs(Rectangle rec1, Rectangle rec2);                                           // Check collision between two rectangles
bool CheckCollisionCircles(Vector2 center1, float radius1, Vector2 center2, float radius2);        // Check collision between two circles
bool CheckCollisionCircleRec(Vector2 center, float radius, Rectangle rec);                         // Check collision between circle and rectangle
bool CheckCollisionPointRec(Vector2 point, Rectangle rec);                                         // Check if point is inside rectangle
bool CheckCollisionPointCircle(Vector2 point, Vector2 center, float radius);                       // Check if point is inside circle
bool CheckCollisionPointTriangle(Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3);               // Check if point is inside a triangle
bool CheckCollisionPointPoly(Vector2 point, Vector2* points, int pointCount);                      // Check if point is within a polygon described by array of vertices
bool CheckCollisionLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2, Vector2* collisionPoint);    // Check the collision between two lines defined by two points each, returns collision point by reference
bool CheckCollisionPointLine(Vector2 point, Vector2 p1, Vector2 p2, int threshold);                // Check if point belongs to line created between two points [p1] and [p2] with defined margin in pixels [threshold]
Rectangle GetCollisionRec(Rectangle rec1, Rectangle rec2);                                         // Get collision rectangle for two rectangles collision
```

## TextureManager
```cs
Image LoadImage(string fileName);                                                                  // Load image from file into CPU memory (RAM)
Image LoadImageRaw(string fileName, int width, int height, int format, int headerSize);            // Load image from RAW file data
Image LoadImageSvg(string fileName, int width, int height);                                        // Load image from SVG file data or string with specified size
Image LoadImageAnim(string fileName, int* frames);                                                 // Load image sequence from file (frames appended to image.data)
Image LoadImageFromMemory(string fileType, byte* fileData, int dataSize);                          // Load image from memory buffer, fileType refers to extension: i.e. '.png'
Image LoadImageFromTexture(Texture2D texture);                                                     // Load image from GPU texture data
Image LoadImageFromScreen();                                                                       // Load image from screen buffer and (screenshot)
bool IsImageReady(Image image);                                                                    // Check if an image is ready
void UnloadImage(Image image);                                                                     // Unload image from CPU memory (RAM)
bool ExportImage(Image image, string fileName);                                                    // Export image data to file, returns true on success
char* ExportImageToMemory(Image image, string fileType, int* fileSize);                            // Export image to memory buffer
bool ExportImageAsCode(Image image, string fileName);                                              // Export image as code file defining an array of bytes, returns true on success

Image GenImageColor(int width, int height, Color color);                                           // Generate image: plain color
Image GenImageGradientLinear(int width, int height, int direction, Color start, Color end);        // Generate image: linear gradient, direction in degrees [0..360], 0=Vertical gradient
Image GenImageGradientRadial(int width, int height, float density, Color inner, Color outer);      // Generate image: radial gradient
Image GenImageGradientSquare(int width, int height, float density, Color inner, Color outer);      // Generate image: square gradient
Image GenImageChecked(int width, int height, int checksX, int checksY, Color col1, Color col2);    // Generate image: checked
Image GenImageWhiteNoise(int width, int height, float factor);                                     // Generate image: white noise
Image GenImagePerlinNoise(int width, int height, int offsetX, int offsetY, float scale);           // Generate image: perlin noise
Image GenImageCellular(int width, int height, int tileSize);                                       // Generate image: cellular algorithm, bigger tileSize means bigger cells
Image GenImageText(int width, int height, string text);                                            // Generate image: grayscale image from text data

Image ImageCopy(Image image);                                                                      // Create an image duplicate (useful for transformations)
Image ImageFromImage(Image image, Rectangle rec);                                                  // Create an image from another image piece
Image ImageText(string text, int fontSize, Color color);                                           // Create an image from text (default font)
Image ImageTextEx(Font font, string text, float fontSize, float spacing, Color tint);              // Create an image from text (custom sprite font)
void ImageFormat(ref Image image, int newFormat);                                                  // Convert image data to desired format
void ImageToPOT(ref Image image, Color fill);                                                      // Convert image to POT (power-of-two)
void ImageCrop(ref Image image, Rectangle crop);                                                   // Crop an image to a defined rectangle
void ImageAlphaCrop(ref Image image, float threshold);                                             // Crop image depending on alpha value
void ImageAlphaClear(ref Image image, Color color, float threshold);                               // Clear alpha channel to desired color
void ImageAlphaMask(ref Image image, Image alphaMask);                                             // Apply alpha mask to image
void ImageAlphaPremultiply(ref Image image);                                                       // Premultiply alpha channel
void ImageBlurGaussian(ref Image image, int blurSize);                                             // Apply Gaussian blur using a box blur approximation
void ImageResize(ref Image image, int newWidth, int newHeight);                                    // Resize image (Bicubic scaling algorithm)
void ImageResizeNN(ref Image image, int newWidth,int newHeight);                                   // Resize image (Nearest-Neighbor scaling algorithm)
void ImageResizeCanvas(ref Image image, int newWidth, int newHeight, int offsetX, int offsetY, Color fill);    // Resize canvas and fill with color
void ImageMipmaps(ref Image image);                                                                // Compute all mipmap levels for a provided image
void ImageDither(ref Image image, int rBpp, int gBpp, int bBpp, int aBpp);                         // Dither image data to 16bpp or lower (Floyd-Steinberg dithering)
void ImageFlipVertical(ref Image image);                                                           // Flip image vertically
void ImageFlipHorizontal(ref Image image);                                                         // Flip image horizontally
void ImageRotate(ref Image image, int degrees);                                                    // Rotate image by input angle in degrees (-359 to 359)
void ImageRotateCW(ref Image image);                                                               // Rotate image clockwise 90deg
void ImageRotateCCW(ref Image image);                                                              // Rotate image counter-clockwise 90deg
void ImageColorTint(ref Image image, Color color);                                                 // Modify image color: tint
void ImageColorInvert(ref Image image);                                                            // Modify image color: invert
void ImageColorGrayscale(ref Image image);                                                         // Modify image color: grayscale
void ImageColorContrast(ref Image image, float contrast);                                          // Modify image color: contrast (-100 to 100)
void ImageColorBrightness(ref Image image, int brightness);                                        // Modify image color: brightness (-255 to 255)
void ImageColorReplace(ref Image image, Color color, Color replace);                               // Modify image color: replace color
Color* LoadImageColors(Image image);                                                               // Load color data from image as a Color array (RGBA - 32bit)
Color* LoadImagePalette(Image image, int maxPaletteSize, int* colorCount);                         // Load colors palette from image as a Color array (RGBA - 32bit)
void UnloadImageColors(Color* colors);                                                             // Unload color data loaded with LoadImageColors()
void UnloadImagePalette(Color* colors);                                                            // Unload colors palette loaded with LoadImagePalette()
Rectangle GetImageAlphaBorder(Image image, float threshold);                                       // Get image alpha border rectangle
Color GetImageColor(Image image, int x, int y);                                                    // Get image pixel color at (x, y) position

void ImageClearBackground(ref Image dst, Color color);                                             // Clear image background with given color
void ImageDrawPixel(ref Image dst, int posX, int posY, Color color);                               // Draw pixel within an image
void ImageDrawPixelV(ref Image dst, Vector2 position, Color color);                                // Draw pixel within an image (Vector version)
void ImageDrawLine(ref Image dst, int startPosX, int startPosY, int endPosX, int endPosY, Color color);    // Draw line within an image
void ImageDrawLineV(ref Image dst, Vector2 start, Vector2 end, Color color);                       // Draw line within an image (Vector version)
void ImageDrawCircle(ref Image dst, int centerX, int centerY, int radius, Color color);            // Draw a filled circle within an image
void ImageDrawCircleV(ref Image dst, Vector2 center, int radius, Color color);                     // Draw a filled circle within an image (Vector version)
void ImageDrawCircleLines(ref Image dst, int centerX, int centerY, int radius, Color color);       // Draw circle outline within an image
void ImageDrawCircleLinesV(ref Image dst, Vector2 center, int radius, Color color);                // Draw circle outline within an image (Vector version)
void ImageDrawRectangle(ref Image dst, int posX, int posY, int width, int height, Color color);    // Draw rectangle within an image
void ImageDrawRectangleV(ref Image dst, Vector2 position, Vector2 size, Color color);              // Draw rectangle within an image (Vector version)
void ImageDrawRectangleRec(ref Image dst, Rectangle rec, Color color);                             // Draw rectangle within an image
void ImageDrawRectangleLines(ref Image dst, Rectangle rec, int thick, Color color);                // Draw rectangle lines within an image
void ImageDraw(ref Image dst, Image src, Rectangle srcRec, Rectangle dstRec, Color tint);          // Draw a source image within a destination image (tint applied to source)
void ImageDrawText(ref Image dst, string text, int posX, int posY, int fontSize, Color color);     // Draw text (using default font) within an image (destination)
void ImageDrawTextEx(ref Image dst, Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);    // Draw text (custom sprite font) within an image (destination)

Texture2D LoadTexture(strin fileName);                                                             // Load texture from file into GPU memory (VRAM)
Texture2D LoadTextureFromImage(Image image);                                                       // Load texture from image data
TextureCubemap LoadTextureCubemap(Image image, int layout);                                        // Load cubemap from image, multiple image cubemap layouts supported
RenderTexture2D LoadRenderTexture(int width, int height);                                          // Load texture for rendering (framebuffer)
bool IsTextureReady(Texture2D texture);                                                            // Check if a texture is ready
void UnloadTexture(Texture2D texture);                                                             // Unload texture from GPU memory (VRAM)
bool IsRenderTextureReady(RenderTexture2D target);                                                 // Check if a render texture is ready
void UnloadRenderTexture(RenderTexture2D target);                                                  // Unload render texture from GPU memory (VRAM)
void UpdateTexture(Texture2D texture, void* pixels);                                               // Update GPU texture with new data
void UpdateTextureRec(Texture2D texture, Rectangle rec, void* pixels);                             // Update GPU texture rectangle with new data

void GenTextureMipmaps(ref Texture2D texture);                                                     // Generate GPU mipmaps for a texture
void SetTextureFilter(Texture2D texture, int filter);                                              // Set texture scaling filter mode
void SetTextureWrap(Texture2D texture, int wrap);                                                  // Set texture wrapping mode

void DrawTexture(Texture2D texture, int posX, int posY, Color tint);                               // Draw a Texture2D
void DrawTextureV(Texture2D texture, Vector2 position, Color tint);                                // Draw a Texture2D with position defined as Vector2
void DrawTextureEx(Texture2D texture, Vector2 position, float rotation, float scale, Color tint);  // Draw a Texture2D with extended parameters
void DrawTextureRec(Texture2D texture, Rectangle source, Vector2 position, Color tint);            // Draw a part of a texture defined by a rectangle
void DrawTexturePro(Texture2D texture, Rectangle source, Rectangle dest, Vector2 origin, float rotation, Color tint);    // Draw a part of a texture defined by a rectangle with 'pro' parameters
void DrawTextureNPatch(Texture2D texture, NPatchInfo nPatchInfo, Rectangle dest, Vector2 origin, float rotation, Color tint);    // Draws a texture (or part of it) that stretches or shrinks nicely

Color Fade(Color color, float alpha);                                 // Get color with alpha applied, alpha goes from 0.0f to 1.0f
int ColorToInt(Color color);                                          // Get hexadecimal value for a Color
Vector4 ColorNormalize(Color color);                                  // Get Color normalized as float [0..1]
Color ColorFromNormalized(Vector4 normalized);                        // Get Color from normalized values [0..1]
Vector3 ColorToHSV(Color color);                                      // Get HSV values for a Color, hue [0..360], saturation/value [0..1]
Color ColorFromHSV(float hue, float saturation, float value);         // Get a Color from HSV values, hue [0..360], saturation/value [0..1]
Color ColorTint(Color color, Color tint);                             // Get color multiplied with another color
Color ColorBrightness(Color color, float factor);                     // Get color with brightness correction, brightness factor goes from -1.0f to 1.0f
Color ColorContrast(Color color, float contrast);                     // Get color with contrast correction, contrast values between -1.0f and 1.0f
Color ColorAlpha(Color color, float alpha);                           // Get color with alpha applied, alpha goes from 0.0f to 1.0f
Color ColorAlphaBlend(Color dst, Color src, Color tint);              // Get src alpha-blended into dst color with tint
Color GetColor(int hexValue);                                // Get Color structure from hexadecimal value
Color GetPixelColor(void* srcPtr, int format);                        // Get Color from a source pixel pointer of certain format
void SetPixelColor(void* dstPtr, Color color, int format);            // Set color formatted into destination pixel pointer
int GetPixelDataSize(int width, int height, int format);              // Get pixel data size in bytes for certain format
```

## TextManager
```cs
Font GetFontDefault();                                                                // Get the default Font
Font LoadFont(string fileName);                                                       // Load font from file into GPU memory (VRAM)
Font LoadFontEx(string fileName, int fontSize, int* codepoints, int codepointCount);  // Load font from file with extended parameters, use NULL for codepoints and 0 for codepointCount to load the default character set
Font LoadFontFromImage(Image image, Color key, int firstChar);                        // Load font from Image (XNA style)
Font LoadFontFromMemory(string fileType, byte* fileData, int dataSize, int fontSize, int* codepoints, int codepointCount);   // Load font from memory buffer, fileType refers to extension: i.e. '.ttf'
bool IsFontReady(Font font);                                                          // Check if a font is ready
GlyphInfo* LoadFontData(byte* fileData, int dataSize, int fontSize, int* codepoints, int codepointCount, int type);   // Load font data for further use
Image GenImageFontAtlas(GlyphInfo* glyphs, Rectangle** glyphRecs, int glyphCount, int fontSize, int padding, int packMethod);   // Generate image font atlas using chars info
void UnloadFontData(GlyphInfo* glyphs, int glyphCount);                               // Unload font chars info data (RAM)
void UnloadFont(Font font);                                                           // Unload font from GPU memory (VRAM)
bool ExportFontAsCode(Font font, string fileName);                                    // Export font as code file, returns true on success

void DrawFPS(int posX, int posY);                                                     // Draw current FPS
void DrawText(string text, int posX, int posY, int fontSize, Color color);            // Draw text (using default font)
void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);                                    // Draw text using font and additional parameters
void DrawTextPro(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint);   // Draw text using Font and pro parameters (rotation)
void DrawTextCodepoint(Font font, int codepoint, Vector2 position, float fontSize, Color tint);                                          // Draw one character (codepoint)
void DrawTextCodepoints(Font font, int* codepoints, int codepointCount, Vector2 position, float fontSize, float spacing, Color tint);    // Draw multiple character (codepoint)

void SetTextLineSpacing(int spacing);                                                 // Set vertical line spacing when drawing with line-breaks
int MeasureText(string text, int fontSize);                                           // Measure string width for default font
Vector2 MeasureTextEx(Font font, string text, float fontSize, float spacing);         // Measure string size for Font
int GetGlyphIndex(Font font, int codepoint);                                          // Get glyph index position in font for a codepoint (unicode character), fallback to '?' if not found
GlyphInfo GetGlyphInfo(Font font, int codepoint);                                     // Get glyph font info data for a codepoint (unicode character), fallback to '?' if not found
Rectangle GetGlyphAtlasRec(Font font, int codepoint);                                 // Get glyph rectangle in font atlas for a codepoint (unicode character), fallback to '?' if not found

string LoadUTF8(int* codepoints, int length);                // Load UTF-8 text encoded from codepoints array
void UnloadUTF8(string text);                                // Unload UTF-8 text encoded from codepoints array
int* LoadCodepoints(string text, int* count);                // Load all codepoints from a UTF-8 text string, codepoints count returned by parameter
void UnloadCodepoints(int* codepoints);                      // Unload codepoints data from memory
int GetCodepointCount(string text);                          // Get total number of codepoints in a UTF-8 encoded string
int GetCodepoint(string text, int* codepointSize);           // Get next codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure
int GetCodepointNext(string text, int *codepointSize);       // Get next codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure
int GetCodepointPrevious(string text, int* codepointSize);   // Get previous codepoint in a UTF-8 encoded string, 0x3f('?') is returned on failure
string CodepointToUTF8(int codepoint, int* utf8Size);        // Encode one codepoint into UTF-8 byte array (array length returned as parameter)

int TextCopy(string dst, string src);                              // Copy one string to another, returns bytes copied
bool TextIsEqual(string text1, string text2);                      // Check if two text string are equal
int TextLength(string text);                                       // Get text length, checks for '\0' ending
string TextFormat(string text, ...);                               // Text formatting with variables (sprintf() style)
string TextSubtext(string text, int position, int length);         // Get a piece of a text string
string TextReplace(string text, string replace, string by);        // Replace text string (WARNING: memory must be freed!)
string TextInsert(string text, string insert, int position);       // Insert text in a position (WARNING: memory must be freed!)
string TextJoin(sbyte** textList, int count, string delimiter);    // Join text strings with delimiter
sbyte** TextSplit(string text, char delimiter, int* count);        // Split text into multiple strings
void TextAppend(string text, string append, int* position);        // Append text at specific position and move cursor!
int TextFindIndex(string text, string find);                       // Find first text occurrence within a string
string TextToUpper(string text);                                   // Get upper case version of provided string
string TextToLower(string text);                                   // Get lower case version of provided string
string TextToPascal(string text);                                  // Get Pascal case notation version of provided string
int TextToInteger(string text);                                    // Get integer value from text (negative values not supported)
```

## ModelManager
```cs
void DrawLine3D(Vector3 startPos, Vector3 endPos, Color color);                                    // Draw a line in 3D world space
void DrawPoint3D(Vector3 position, Color color);                                                   // Draw a point in 3D space, actually a small line
void DrawCircle3D(Vector3 center, float radius, Vector3 rotationAxis, float rotationAngle, Color color);    // Draw a circle in 3D world space
void DrawTriangle3D(Vector3 v1, Vector3 v2, Vector3 v3, Color color);                              // Draw a color-filled triangle (vertex in counter-clockwise order!)
void DrawTriangleStrip3D(Vector3* points, int pointCount, Color color);                            // Draw a triangle strip defined by points
void DrawCube(Vector3 position, float width, float height, float length, Color color);             // Draw cube
void DrawCubeV(Vector3 position, Vector3 size, Color color);                                       // Draw cube (Vector version)
void DrawCubeWires(Vector3 position, float width, float height, float length, Color color);        // Draw cube wires
void DrawCubeWiresV(Vector3 position, Vector3 size, Color color);                                  // Draw cube wires (Vector version)
void DrawSphere(Vector3 centerPos, float radius, Color color);                                     // Draw sphere
void DrawSphereEx(Vector3 centerPos, float radius, int rings, int slices, Color color);            // Draw sphere with extended parameters
void DrawSphereWires(Vector3 centerPos, float radius, int rings, int slices, Color color);         // Draw sphere wires
void DrawCylinder(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);        // Draw a cylinder/cone
void DrawCylinderEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color);      // Draw a cylinder with base at startPos and top at endPos
void DrawCylinderWires(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);   // Draw a cylinder/cone wires
void DrawCylinderWiresEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color); // Draw a cylinder wires with base at startPos and top at endPos
void DrawCapsule(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color);                   // Draw a capsule with the center of its sphere caps at startPos and endPos
void DrawCapsuleWires(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color);              // Draw capsule wireframe with the center of its sphere caps at startPos and endPos
void DrawPlane(Vector3 centerPos, Vector2 size, Color color);                                      // Draw a plane XZ
void DrawRay(Ray ray, Color color);                                                                // Draw a ray line
void DrawGrid(int slices, float spacing);                                                          // Draw a grid (centered at (0, 0, 0))

Model LoadModel(string fileName);                                                     // Load model from files (meshes and materials)
Model LoadModelFromMesh(Mesh mesh);                                                   // Load model from generated mesh (default material)
bool IsModelReady(Model model);                                                       // Check if a model is ready
void UnloadModel(Model model);                                                        // Unload model (including meshes) from memory (RAM and/or VRAM)
BoundingBox GetModelBoundingBox(Model model);                                         // Compute model bounding box limits (considers all meshes)

void DrawModel(Model model, Vector3 position, float scale, Color tint);               // Draw a model (with texture if set)
void DrawModelEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);    // Draw a model with extended parameters
void DrawModelWires(Model model, Vector3 position, float scale, Color tint);          // Draw a model wires (with texture if set)
void DrawModelWiresEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);    // Draw a model wires (with texture if set) with extended parameters
void DrawBoundingBox(BoundingBox box, Color color);                                   // Draw bounding box (wires)
void DrawBillboard(Camera3D camera, Texture2D texture, Vector3 position, float size, Color tint);   // Draw a billboard texture
void DrawBillboardRec(Camera3D camera, Texture2D texture, Rectangle source, Vector3 position, Vector2 size, Color tint);    // Draw a billboard texture defined by source
void DrawBillboardPro(Camera3D camera, Texture2D texture, Rectangle source, Vector3 position, Vector3 up, Vector2 size, Vector2 origin, float rotation, Color tint); // Draw a billboard texture defined by source and rotation

void UploadMesh(ref Mesh mesh, bool dynamic);                                         // Upload mesh vertex data in GPU and provide VAO/VBO ids
void UpdateMeshBuffer(Mesh mesh, int index, void* data, int dataSize, int offset);    // Update mesh vertex data in GPU for a specific buffer index
void UnloadMesh(Mesh mesh);                                                           // Unload mesh data from CPU and GPU
void DrawMesh(Mesh mesh, Material material, Matrix4x4 transform);                     // Draw a 3d mesh with material and transform
void DrawMeshInstanced(Mesh mesh, Material material, Matrix4x4* transforms, int instances);    // Draw multiple mesh instances with material and different transforms
bool ExportMesh(Mesh mesh, string fileName);                                          // Export mesh data to file, returns true on success
BoundingBox GetMeshBoundingBox(Mesh mesh);                                            // Compute mesh bounding box limits
void GenMeshTangents(ref Mesh mesh);                                                  // Compute mesh tangents

Mesh GenMeshPoly(int sides, float radius);                                            // Generate polygonal mesh
Mesh GenMeshPlane(float width, float length, int resX, int resZ);                     // Generate plane mesh (with subdivisions)
Mesh GenMeshCube(float width, float height, float length);                            // Generate cuboid mesh
Mesh GenMeshSphere(float radius, int rings, int slices);                              // Generate sphere mesh (standard sphere)
Mesh GenMeshHemiSphere(float radius, int rings, int slices);                          // Generate half-sphere mesh (no bottom cap)
Mesh GenMeshCylinder(float radius, float height, int slices);                         // Generate cylinder mesh
Mesh GenMeshCone(float radius, float height, int slices);                             // Generate cone/pyramid mesh
Mesh GenMeshTorus(float radius, float size, int radSeg, int sides);                   // Generate torus mesh
Mesh GenMeshKnot(float radius, float size, int radSeg, int sides);                    // Generate trefoil knot mesh
Mesh GenMeshHeightmap(Image heightmap, Vector3 size);                                 // Generate heightmap mesh from image data
Mesh GenMeshCubicmap(Image cubicmap, Vector3 cubeSize);                               // Generate cubes-based map mesh from image data

Material* LoadMaterials(string fileName, out int materialCount);                      // Load materials from model file
Material LoadMaterialDefault(void);                                                   // Load default material (Supports: DIFFUSE, SPECULAR, NORMAL maps)
bool IsMaterialReady(Material material);                                              // Check if a material is ready
void UnloadMaterial(Material material);                                               // Unload material from GPU memory (VRAM)
void SetMaterialTexture(ref Material material, int mapType, Texture2D texture);       // Set texture for a material map type (MATERIAL_MAP_DIFFUSE, MATERIAL_MAP_SPECULAR...)
void SetModelMeshMaterial(ref Model model, int meshId, int materialId);               // Set material for a mesh

ModelAnimation* LoadModelAnimations(string fileName, out int animCount);              // Load model animations from file
void UpdateModelAnimation(Model model, ModelAnimation anim, int frame);               // Update model animation pose
void UnloadModelAnimation(ModelAnimation anim);                                       // Unload animation data
void UnloadModelAnimations(ModelAnimation* animations, int animCount);                // Unload animation array data
bool IsModelAnimationValid(Model model, ModelAnimation anim);                         // Check model animation skeleton match

bool CheckCollisionSpheres(Vector3 center1, float radius1, Vector3 center2, float radius2);   // Check collision between two spheres
bool CheckCollisionBoxes(BoundingBox box1, BoundingBox box2);                                 // Check collision between two bounding boxes
bool CheckCollisionBoxSphere(BoundingBox box, Vector3 center, float radius);                  // Check collision between box and sphere
RayCollision GetRayCollisionSphere(Ray ray, Vector3 center, float radius);                    // Get collision info between ray and sphere
RayCollision GetRayCollisionBox(Ray ray, BoundingBox box);                                    // Get collision info between ray and box
RayCollision GetRayCollisionMesh(Ray ray, Mesh mesh, Matrix4x4 transform);                    // Get collision info between ray and mesh
RayCollision GetRayCollisionTriangle(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3);            // Get collision info between ray and triangle
RayCollision GetRayCollisionQuad(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4);    // Get collision info between ray and quad
```

## AudioManager
```cs
void InitAudioDevice();                                         // Initialize audio device and context
void CloseAudioDevice();                                        // Close the audio device and context
bool IsAudioDeviceReady();                                      // Check if audio device has been initialized successfully
void SetMasterVolume(float volume);                             // Set master volume (listener)
float GetMasterVolume();                                        // Get master volume (listener)

Wave LoadWave(string fileName);                                 // Load wave data from file
Wave LoadWaveFromMemory(string fileType, byte* fileData, int dataSize);    // Load wave from memory buffer, fileType refers to extension: i.e. '.wav'
bool IsWaveReady(Wave wave);                                    // Checks if wave data is ready
Sound LoadSound(string fileName);                               // Load sound from file
Sound LoadSoundFromWave(Wave wave);                             // Load sound from wave data
Sound LoadSoundAlias(Sound source);                             // Create a new sound that shares the same sample data as the source sound, does not own the sound data
bool IsSoundReady(Sound sound);                                 // Checks if a sound is ready
void UpdateSound(Sound sound, void* data, int sampleCount);     // Update sound buffer with new data
void UnloadWave(Wave wave);                                     // Unload wave data
void UnloadSound(Sound sound);                                  // Unload sound
void UnloadSoundAlias(Sound alias);                             // Unload a sound alias (does not deallocate sample data)
bool ExportWave(Wave wave, string fileName);                    // Export wave data to file, returns true on success
bool ExportWaveAsCode(Wave wave, string fileName);              // Export wave sample data to code (.h), returns true on success

void PlaySound(Sound sound);                                    // Play a sound
void StopSound(Sound sound);                                    // Stop playing a sound
void PauseSound(Sound sound);                                   // Pause a sound
void ResumeSound(Sound sound);                                  // Resume a paused sound
bool IsSoundPlaying(Sound sound);                               // Check if a sound is currently playing
void SetSoundVolume(Sound sound, float volume);                 // Set volume for a sound (1.0 is max level)
void SetSoundPitch(Sound sound, float pitch);                   // Set pitch for a sound (1.0 is base level)
void SetSoundPan(Sound sound, float pan);                       // Set pan for a sound (0.5 is center)
Wave WaveCopy(Wave wave);                                       // Copy a wave to a new wave
void WaveCrop(ref Wave wave, int initSample, int finalSample);  // Crop a wave to defined samples range
void WaveFormat(ref Wave wave, int sampleRate, int sampleSize, int channels);   // Convert wave data to desired format
float* LoadWaveSamples(Wave wave);                              // Load samples data from wave as a 32bit float data array
void UnloadWaveSamples(float* samples);                         // Unload samples data loaded with LoadWaveSamples()

Music LoadMusicStream(string fileName);                    // Load music stream from file
Music LoadMusicStreamFromMemory(string fileType, byte* data, int dataSize);   // Load music stream from data
bool IsMusicReady(Music music);                                 // Checks if a music stream is ready
void UnloadMusicStream(Music music);                            // Unload music stream
void PlayMusicStream(Music music);                              // Start music playing
bool IsMusicStreamPlaying(Music music);                         // Check if music is playing
void UpdateMusicStream(Music music);                            // Updates buffers for music streaming
void StopMusicStream(Music music);                              // Stop music playing
void PauseMusicStream(Music music);                             // Pause music playing
void ResumeMusicStream(Music music);                            // Resume playing paused music
void SeekMusicStream(Music music, float position);              // Seek music to a position (in seconds)
void SetMusicVolume(Music music, float volume);                 // Set volume for music (1.0 is max level)
void SetMusicPitch(Music music, float pitch);                   // Set pitch for a music (1.0 is base level)
void SetMusicPan(Music music, float pan);                       // Set pan for a music (0.5 is center)
float GetMusicTimeLength(Music music);                          // Get music time length (in seconds)
float GetMusicTimePlayed(Music music);                          // Get current music time played (in seconds)

AudioStream LoadAudioStream(int sampleRate, int sampleSize, int channels); // Load audio stream (to stream raw audio pcm data)
bool IsAudioStreamReady(AudioStream stream);                    // Checks if an audio stream is ready
void UnloadAudioStream(AudioStream stream);                     // Unload audio stream and free memory
void UpdateAudioStream(AudioStream stream, void* data, int frameCount); // Update audio stream buffers with data
bool IsAudioStreamProcessed(AudioStream stream);                // Check if any audio stream buffers requires refill
void PlayAudioStream(AudioStream stream);                       // Play audio stream
void PauseAudioStream(AudioStream stream);                      // Pause audio stream
void ResumeAudioStream(AudioStream stream);                     // Resume audio stream
bool IsAudioStreamPlaying(AudioStream stream);                  // Check if audio stream is playing
void StopAudioStream(AudioStream stream);                       // Stop audio stream
void SetAudioStreamVolume(AudioStream stream, float volume);    // Set volume for audio stream (1.0 is max level)
void SetAudioStreamPitch(AudioStream stream, float pitch);      // Set pitch for audio stream (1.0 is base level)
void SetAudioStreamPan(AudioStream stream, float pan);          // Set pan for audio stream (0.5 is centered)
void SetAudioStreamBufferSizeDefault(int size);                 // Default size for new audio streams
void SetAudioStreamCallback(AudioStream stream, delegate* unmanaged[Cdecl]<void*, uint, void> callback);    // Audio thread callback to request new data

void AttachAudioStreamProcessor(AudioStream stream, delegate* unmanaged[Cdecl]<void*, uint, void> processor);   // Attach audio stream processor to stream, receives the samples as <float>s
void DetachAudioStreamProcessor(AudioStream stream, delegate* unmanaged[Cdecl]<void*, uint, void> processor);   // Detach audio stream processor from stream

void AttachAudioMixedProcessor(delegate* unmanaged[Cdecl]<void*, uint, void> processor);   // Attach audio stream processor to the entire audio pipeline, receives the samples as <float>s
void DetachAudioMixedProcessor(delegate* unmanaged[Cdecl]<void*, uint, void> processor);   // Detach audio stream processor from the entire audio pipeline
```

## Structs
```cs
struct AudioStream                                    // AudioStream, custom audio stream
struct Music                                          // Music, audio stream, anything longer than ~10 seconds should be streamed
struct Sound                                          // Sound
struct Wave                                           // Wave, audio wave data

struct AutomationEvent                                // Automation event
struct AutomationEventList                            // Automation event list

struct Camera2D                                       // Camera2D, defines position/orientation in 2d space
struct Camera3D                                       // Camera, defines position/orientation in 3d space

struct BoundingBox                                    // BoundingBox
struct Ray                                            // Ray, ray for raycasting
struct RayCollision                                   // RayCollision, ray hit information

struct Font                                           // Font, font texture and GlyphInfo array data
struct GlyphInfo                                      // GlyphInfo, font characters glyphs info

struct BoneInfo                                       // Bone, skeletal animation bone
struct Mesh                                           // Mesh, vertex data and vao/vbo
struct Model                                          // Model, meshes, materials and animation data
struct ModelAnimation                                 // ModelAnimation

struct FilePathList                                   // File path list

struct Image                                          // Image, pixel data stored in CPU memory (RAM)

struct Material                                       // Material, includes shader and maps
struct MaterialMap                                    // MaterialMap

struct Color                                          // Color, 4 components, R8G8B8A8 (32bit)
struct Transform                                      // Transform, vectex transformation data

struct DrawCall                                       // DrawCall
struct RenderBatch                                    // RenderBatch
struct VertexBuffer                                   // VertexBuffer

struct Shader                                         // Shader

struct Texture2D                                      // Texture, tex data stored in GPU memory (VRAM)

struct NPatchInfo                                     // NPatchInfo, n-patch layout info
struct RenderTexture2D                                // RenderTexture, fbo for texture rendering

struct VrDeviceInfo                                   // VrDeviceInfo, Head-Mounted-Display device parameters
struct VrStereoConfig                                 // VrStereoConfig, VR stereo rendering configuration for simulator
```

## Enums
```cs
enum AutomationEventType

enum CameraMode
enum CameraProjection

enum FontType

enum PixelFormat

enum GamepadAxis
enum GamepadButton
enum Gesture
enum MouseButton 
enum KeyboardKey
enum MouseButton
enum MouseCursor

enum TraceLogLevel

enum MaterialMapIndex

enum FramebufferAttachTextureType
enum FramebufferAttachType

enum CullMode
enum DrawMode
enum GlVersion
enum MatrixMode

enum ShaderAttributeDataType
enum ShaderLocationIndex
enum ShaderUniformDataType

enum CubemapLayout
enum TextureFilter
enum TextureWrap

enum BlendMode
enum NPatchLayout

enum ConfigFlags
```

## Colors
```cs
Color LightGray = new Color(200, 200, 200, 255);    // Light Gray
Color Gray = new Color(130, 130, 130, 255);         // Gray
Color DarkGray = new Color(80, 80, 80, 255);        // Dark Gray
Color Yellow = new Color(253, 249, 0, 255);         // Yellow
Color Gold = new Color(255, 203, 0, 255);           // Gold
Color Orange = new Color(255, 161, 0, 255);         // Orange
Color Pink = new Color(255, 109, 194, 255);         // Pink
Color Red = new Color(230, 41, 55, 255);            // Red
Color Maroon = new Color(190, 33, 55, 255);         // Maroon
Color Green = new Color(0, 228, 48, 255);           // Green
Color Lime = new Color(0, 158, 47, 255);            // Lime
Color DarkGreen = new Color(0, 117, 44, 255);       // Dark Green
Color SkyBlue = new Color(102, 191, 255, 255);      // Sky Blue
Color Blue = new Color(0, 121, 241, 255);           // Blue
Color DarkBlue = new Color(0, 82, 172, 255);        // Dark Blue
Color Purple = new Color(200, 122, 255, 255);       // Purple
Color Violet = new Color(135, 60, 190, 255);        // Violet
Color DarkPurple = new Color(112, 31, 126, 255);    // Dark Purple
Color Beige = new Color(211, 176, 131, 255);        // Beige
Color Brown = new Color(127, 106, 79, 255);         // Brown
Color DarkBrown = new Color(76, 63, 47, 255);       // Dark Brown

Color White = new Color(255, 255, 255, 255);        // White
Color Black = new Color(0, 0, 0, 255);              // Black
Color Blank = new Color(0, 0, 0, 0);                // Blank (Transparent)
Color Magenta = new Color(255, 0, 255, 255);        // Magenta
Color RayWhite = new Color(245, 245, 245, 255);     // My own White (raylib logo)
```