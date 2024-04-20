# AlphaDemo

# Entry point
- Starts with the **AlphaDemoWebApi**
- In **HomeController**
- Code commented out in Index() as var result = await iLogItem.GetErrorLog()

# Structure
- **AlphaDemoWebApi** calls GetErrorLog() in
- **AlphaDemoWebApi.Service** via interface AlphaDemoWebApi.Service.Interface calls GetErrorLog() in
- **AlphaDemoWebApi.Respository** via interface AlphaDemoWebApi.Respository.Interface

# Notes
- Providing inversion of control via interfaces
- Models held in seperate project **AlphaDemoWebApi.Model** so projects are abstract and not dependant on each other
- Concrete project **AlphaDemoWebApi.Respository** is the only one with nuget reference to Entity Framework, no other project will have reference to it.
- IOC defined in UnityConfig.cs in main **AlphaDemoWebApi** project
