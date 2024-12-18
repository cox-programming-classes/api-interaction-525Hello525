namespace CS8_MessageAPI.Models;
/// <summary>
/// An academic block
/// </summary>
/// <param name="blockId">don't care</param>
/// <param name="name">Nmae of the block</param>
/// <param name="schoollevel">Upper or Lower school</param>
public record Block(
    string blockId,
    string name,
    string schoollevel);
/// <summary>
/// Time period that you're free
/// </summary>
/// <param name="block">Block information</param>
/// <param name="start">when the free block starts</param>
/// <param name="end">when the free block ends</param>
public record FreeBlock(
    Block block,
    DateTime start,
    DateTime end);
    
/// <summary>
/// response to a request for free-blocks in a given range of dates
/// </summary>
/// <param name="freeBlocks"></param>
/// <param name="inRange"></param>
public record FreeBlockCollection(
    FreeBlock[] freeBlocks,
    DateOnly[] inRange);