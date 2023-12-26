# Dropa Generic Mapper

using Mapper.Ext;
Use ;
```
builder.Services.AddGenericMap<TDto>();
```

Example;
```
builder.Services.AddGenericMap<TestEntity>();
```
DI;
```
private readonly IGenericMapExtensions<TestEntity> _testEntityMapper;
public Controller(IGenericMapExtensions<TestEntity> testEntityMapper)
{
	_logger = logger;
	_testEntityMapper = testEntityMapper;
}
```

```
var list = new List<object>();
var mappedList = _testEntityMapper.Map(list, new TestEntity());
```
# **Happy Code !**

