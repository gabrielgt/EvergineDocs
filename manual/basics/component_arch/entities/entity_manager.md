# EntityManager

**EntityManager** is the subsystem in the Scene responsible to manage Entities. It is responsible to maintain the Entity list, and the lifecycle of each one.

Useful ways to interact with EntityManager:

## Add and Remove Entities

The most common way to interact with EntityManager is by adding and removing entities:

```csharp
EntityManager entityManager = scene.Managers.EntityManager;

// Add an Entity to the Scene..
entityManager.Add(entity);

// Remove an Entity from the Scene...
entityManager.Remove(entity);
```

## Important Properties

| Method | Description | 
| ------ | ----------- |
| **EntityGraph**| Return the entities at the top level on the scene (Those without parent) |
| **AllEntities** | Return all the entities of the scene, including those who have parent. |

## Find Entities

You can  find Entities in several ways:

### Find Entity by EntityPath

This is the most common way to find an Entity in the Scene, by using its **EntityPath**:

```csharp
// Find an entity by its Entity Path...
var entity = entityManager.Find("Parent.Entity1.ChildEntity");
```

### Find Entity by ID

You can find an Entity if you specify its ID (Guid)

```csharp
// Find an entity by its ID...
Guid id = entity.Id;
var entity = entityManager.Find(id);
```

### Find all Entities by Tag

As we mentined before, you can set the tag Entities by setting the `Tag` property. So, you can obtain an Entity collection that match a given Tag:

```csharp
// Find all entities with a given Tag...
IEnumerable<Entity> entityCollection = entityManager.FindAllByTag("Tag");
```

## Entity Tag Collection

A useful feature of EntityManager is the possibility to obtain a live collection of entities that match a specified Tag.

This collection is represented by the `EntityTagCollection` class. The main advantage compared to invoke `FindAllByTag()` method is that in this case the collection is dynamic during the application lifetime. So, you can subscribe to events to get notified when the collection changes:

Here it is a glimpse of how to use it:

```csharp
// Gets the tag collection...
var tagCollection = entityManager.GetEntityTagCollection("Tag");

// Iterates over all matching entities...
foreach (var entity in tagCollection.Entities)
{
    System.Console.WriteLine(entity.EntityPath);
}

// TagCollection Events:

// OnEntityAdded: Event triggered when a new Entity with the given Tag is added to the Scene...
tagCollection.OnEntityAdded += (sender, entity) => 
{ 
    System.Console.WriteLine($"New entity: {entity.EntityPath}"); 
};

// OnEntityRemoved: Event triggered when an Entity is no longer belong to this collection, 
// becuase the Entity is removed or its Tag has changed...
tagCollection.OnEntityRemoved += (sender, entity) =>
{
    System.Console.WriteLine($"Entity removed: {entity.EntityPath}");
};
```