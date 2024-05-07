# Naming Convention

## Boolean Method Naming

start with an action like `IsX` or `HasY`

```cs
/// if a is not 2 or 12 then it is an valid number
static void IsValidNumber(int a)
{
    return a != 2 || a != 12;
};
```

## Positive names for boolean methods

Avoid double negatives expression \
From

```cs
if(!IsValidNumber(a))
{
    // handle the condition ...
}
```

To

```cs
if(IsInvalidNumber(a))
{
    // handle the condition ...
}
// change the condition method logic
static void IsInvalidNumber(int a)
{
    return a == 2 || a == 12;
};
```