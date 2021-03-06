# Westwind.Data.MongoDb
### A MongoDb Business object and data acces library

<img src="http://west-wind.com/WestwindToolkit/images/WestwindWebToolkitData_128x128.png" align="left"/> This library provides a light weight business object wrapper around MongoDb, similar to the EntityFramework [Westwind.Data](../westwind.data) library but using MongoDb. It provides the same CRUD interface for simplified Load(), Save(), Delete(), Validate() and various internal hooks and helpers as well as simplified data operation helpers to reduce the code noise of interfacing with the MongoDb C# driver. 

The class automaps connections, database and an active collection, to make most data operations single line commands. You also still get access to the underlying MongoDb C# driver so you lose nothing in terms of functionality.

This library is somewhat compatible with the EntityFramework version, so it's possible to migrate code from EF to Mongo with some degree of compatibility. The biggest differences will be in LINQ query code which can often be ported to MongoDb's LINQ provider code, or might have to be explicitly set up to use the MongoDb Query objects. 


### License ###
The Westwind Toolkit library is an open source product licensed under **[MIT license](http://opensource.org/licenses/MIT)**, and there's no charge to use, integrate or modify the code for this project. You are free to use it in personal, commercial, government and any other type of application. Commercial licenses are also available.

All source code is copyright West Wind Technologies, regardless of changes made to them. Any source code modifications must leave the original copyright code headers intact.

### Commercial Licenses
The libray is free, but if you prefer, you can also purchase a fully supported commercial license that allows for paid support options. There are two versions available:

* [Single Developer License](http://store.west-wind.com/product/westwind_toolkit/)
* [Organization License](http://store.west-wind.com/product/westwind_toolkit_org/)

### Why buy a license?
Some organizations require a commercial license and support in order to integrate third party software tools into their products. The commercial license provides this level of licensing.

Buying a license also helps support this project and encourages further development and support. While we try to keep the project up to date on an as needed basis, even small financial incentives provide additional motivation to continue to improve and actively support this project. Think of it as a vote of confidence for continued support of the library.
