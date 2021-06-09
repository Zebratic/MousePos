# MousePos
A simple Mouse position program with a drawing function that can be used to get mouse coordinates to control an arduino or other stuff.

## Installation
Simply download the source code and build it using .NET 4.7.2.
Or download the release from [releases](https://github.com/Zebratic/MousePos/releases).

## Usage
You can use this if you need to send mouse coordinates to an external source such as an arduino.
I have personally used this to send mouse coordinates to an arduino controlling motors.

## Notice
There is a flicker when removing previous drawing dots, becuase double buffered pictureboxes dont work well with panels on top of them.
This can be fixed if the mouse position panels are removed.
