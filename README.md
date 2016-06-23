# XamarinTemplate

XamarinStartupTemplate is a templat that includes some Data Model and manager classes which provides some convenience methods.

List of Data Model included:

1. mainObject

Property Name: mainObjectId
Data Type: int
Accessor type: get,set
Access Levels: public

Property Name: Name
Data Type: string
Accessor type: get,set
Access Levels: public

Property Name: ShortDescription
Data Type: string
Accessor type: get,set
Access Levels: public

Property Name: Description
Data Type: string
Accessor type: get,set
Access Levels: public

Property Name: ImagePath
Data Type: string
Accessor type: get,set
Access Levels: public

Property Name: Price
Data Type: int
Accessor type: get,set
Access Levels: public

Property Name: Available
Data Type: bool
Accessor type: get,set
Access Levels: public

Property Name: PrepTime
Data Type: int
Accessor type: get,set
Access Levels: public

Property Name: Ingredients
Data Type: List<string> 
Accessor type: get,set
Access Levels: public

Property Name: IsFavorite
Data Type: bool
Accessor type: get,set
Access Levels: public

Property Name: GroupName
Data Type: string
Accessor type: get,set
Access Levels: public

2. mainObjectGroup

Property Name: mainObjectGroupId
Data Type: int
Accessor type: get,set
Access Levels: public

Property Name: Title
Data Type: string
Accessor type: get,set
Access Levels: public

Property Name: ImagePath
Data Type: string
Accessor type: get,set
Access Levels: public

Property Name: mainObjects
Data Type: List<mainObject> 
Accessor type: get,set
Access Levels: public


List of Manager included:

1. APIManager.

static internal APIManager Instance()

Method Name: Instance
Parameters: nil
Returns: Instance of APIManager Class.

public void FetchAllObjs()

Method Name: FetchAllObjs
Parameters: nil
Returns: nil.

public List<mainObject> GetAllObjs()

Method Name: GetAllObjs
Parameters: nil
Returns: List<mainObject> = List of All Objects.

public mainObject GetObjById(int ObjId)

Method Name: GetObjById
Parameters: ObjId = A Object ID in Integer format.
Returns: mainObject = Object Of ID Passed.

public List<mainObjectGroup> GetGroupedObjs()

Method Name: GetGroupedObjs
Parameters: nil
Returns: List<mainObjectGroup> = List of All Object Groups.

public List<mainObject> GetObjsForGroup(int ObjGroupId)

Method Name: GetObjsForGroup
Parameters: ObjGroupId = A Object Group ID in Integer format.
Returns: List<mainObject> = List of All Objects of Group ID passed.

public List<mainObject> GetFavoriteObjs()

Method Name: GetFavoriteObjs
Parameters: nil
Returns: List<mainObject> = List of All Favorite Objects.

2. ApplicationManager.

static internal ApplicationManager Instance()

Method Name: Instance
Parameters: nil
Returns: Instance of ApplicationManager Class.

public List<mainObject> GetAllObjs()

Method Name: GetAllObjs
Parameters: nil
Returns: List<mainObject> = List of All Objects.

public mainObject GetObjById(int ObjId)

Method Name: GetObjById
Parameters: ObjId = A Object ID in Integer format.
Returns: mainObject = Object Of ID Passed.

public List<mainObjectGroup> GetGroupedObjs()

Method Name: GetGroupedObjs
Parameters: nil
Returns: List<mainObjectGroup> = List of All Object Groups.

public List<mainObject> GetObjsForGroup(int ObjGroupId)

Method Name: GetObjsForGroup
Parameters: ObjGroupId = A Object Group ID in Integer format.
Returns: List<mainObject> = List of All Objects of Group ID passed.

public List<mainObject> GetFavoriteObjs()

Method Name: GetFavoriteObjs
Parameters: nil
Returns: List<mainObject> = List of All Favorite Objects.

3. DatabaseManager.

static internal DatabaseManager Instance()

Method Name: Instance
Parameters: nil
Returns: Instance of DatabaseManager Class.

4. ObjDataService.

public List<mainObject> GetAllObjs()

Method Name: GetAllObjs
Parameters: nil
Returns: List<mainObject> = List of All Objects.

public mainObject GetObjById(int objId)

Method Name: GetObjById
Parameters: ObjId = A Object ID in Integer format.
Returns: mainObject = Object Of ID Passed.

public List<mainObjectGroup> GetGroupedObjs()

Method Name: GetGroupedObjs
Parameters: nil
Returns: List<mainObjectGroup> = List of All Object Groups.

public List<mainObject> GetObjsForGroup(int groupId)

Method Name: GetObjsForGroup
Parameters: groupId = A Group ID in Integer format.
Returns: List<mainObject> = List of All Objects of Group ID passed.

public List<mainObject> GetFavoriteObjs()

Method Name: GetFavoriteObjs
Parameters: nil
Returns: List<mainObject> = List of All Favorite Objects.

