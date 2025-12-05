# RotoUSB

# Overview

RotoUSB is a class library designed to allow communication with the RotoVR base and its attached devices via USB. 

It provides an easy-to-use interface for developers to interact with RotoVR hardware, enabling functionalities such as device detection, data transmission, and control commands.

This library is designd to be used with Net Core Dependency Injection (DI) system.


#Usage

When setting up your DI container, you can register the RotoUSB service as follows:

```csharp
services.AddRotoUSB();
```
