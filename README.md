# BCF Client
[BIM Collaboration Format (BCF)](https://en.wikipedia.org/wiki/BIM_Collaboration_Format) client based on [BIMcollab Developer SDK](https://www.bimcollab.com/en/developers/Developer-SDK).

![BIMcollab SDK](https://img.shields.io/badge/BIMcollab%20SDK-5.0-blue.svg)
![Platform](https://img.shields.io/badge/Platform-Windows-lightgrey.svg)
![.NET](https://img.shields.io/badge/.NET%20Core-3.0-blue)
![Language](https://img.shields.io/badge/Language-C%23-blue)
[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://github.com/NikolaGrujic91/BIMcollab-Playground-WPF-Client/graphs/commit-activity)
[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)


## Table of contents
* [General info](#general-info)
* [Usage](#usage)
* [Components](#components)
* [Technologies](#technologies)
* [Setup](#setup)
* [Features](#features)
* [Status](#status)
* [Inspiration](#inspiration)
* [Licence](#licence)
* [Contact](#contact)

## General info

Project is an example how BIM Collaboration Format (BCF) client can be implemented using [BIMcollab Developer SDK](https://www.bimcollab.com/en/developers/Developer-SDK) Connection library (No GUI).

The BIM Collaboration Format (BCF) is a structured file format suited to issue tracking with a building information model.

Application is implemented using Model-View-ViewModel architectural pattern. Complete GUI is implemented using WPF.

## Usage
### Login and overview of issues

![Login and issues overview](./img/Usage_LoginAndIssuesOverview.gif)

### Edit issue

![Edit issue](./img/Usage_EditIssue.gif)

### Overview of components stored in issue

![Components](./img/Usage_StoredComponents.gif)

### Filter issues by status

![Filtering](./img/Usage_Filtering.gif)

## Components
![Application architecture overview](./img/Architecture.jpg)

## Technologies
* C#
* .NET Core 3.0
* WPF (Windows Presentation Foundation)

## Setup
To run this project make sure you have installed:
* Visual Studio 2019 v16.3 or later
* BIMcollab Developer SDK Libraries and Binaries are already part of the project

## Features

* Connecting to project on playground.bimcollab.com
* Overview of issues
* Detail overview of single issue
* Overview of issue comments
* Publish issues
* Add issue
* Edit issue
* Overview of components stored in issue
* Filter issues by status
* Version of API, WebService and Database

To-do list:
* Bugfixes

## Status
Project is in progress.

## Inspiration
Project inspired by [BIMcollab BCF Manager](https://www.bimcollab.com/en/BCF-Manager/BCF-Manager).

## Licence

This project is licensed under the GNU GPL v3 License - see the [LICENSE.md](https://github.com/NikolaGrujic91/BIMcollab-Playground-WPF-Client/blob/master/LICENSE) file for details.

## Contact
Created by Nikola Grujic - feel free to contact me!

grujic.nikola91@gmail.com

[Nikola Grujic | LinkedIn](https://www.linkedin.com/in/nikola-grujic-735a7284/)
