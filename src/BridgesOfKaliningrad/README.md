# Bridges of Kaliningrad

You have been contracted by a city planning firm which is current designing a new section of the city of Kaliningrad located at the Kaliningrad Bay. Kaliningrad, formerly Königsberg, is infamous for its seven bridges and the [mathematical properties](https://en.wikipedia.org/wiki/Seven_Bridges_of_K%C3%B6nigsberg) they possess. The firm has presented you with several configurations of islands and bridges connecting these islands which the new city section may be located on. However, due to the aforementioned infamous properties of the city's previous bridges, the firm wants to make sure the bridges connecting the islands of the new city section are mathematically capable of being crossed exactly once on a continuous route. Each potential layout of islands and bridges is presented to you in the form of a string of `#` characters representing the islands, ` ` characters representing the surrounding bay, and `-` and `|` characters representing the bridges. An island is defined as a contiguous region of ajacent `#` characters either horizontally or vertically, but not diagonally. A bridge is defined as a contiguous region of vertically ajacent `|` characters or horizontally ajacent `-` characters. A bridge is connected to an island if it is vertically or horizontally ajacent to a `#` character.

### Sample input

```cs
// Valid
string layout =
	"####  #\n" +
	" ##--##\n" +
	" |   # \n" +
	"##   ##\n" +
	" ###-##\n";
```

```cs
// Valid
string layout =
	"###  \n" +
	" ### \n" +
	" | | \n" +
	"##-# \n" +
	"|  ##\n" +
	"##  #\n";
```

```cs
// Invalid
string layout =
	"##########\n" +
	" |  |   | \n" +
	"###### ###\n" +
	"######-###\n" +
	" |  |   | \n" +
	"##########";
```

### Quick start

```cs
public static bool BridgesAreValid(string layout)
{
    throw new NotImplementedException();
}
```

### Feedback

If you have any feedback on this challenge, please open an issue on this repository, mention this challenge, and ping the contributor(s) of this challenge.

### Contributor(s)

- [thinker227](https://github.com/thinker227)

---

Discord meta data. Do not edit. This is used for GitHub => Discord linking.

<table>
<tr>
	<td>Name
	<td>Bridges of Kaliningrad
<tr>
	<td>Description
	<td>You have been contracted by a city planning firm which is current designing a new section of the city of Kaliningrad located at the Kaliningrad Bay. Kaliningrad, formerly Königsberg, is infamous for its seven bridges and the [mathematical properties](https://en.wikipedia.org/wiki/Seven_Bridges_of_K%C3%B6nigsberg) they possess. The firm has presented you with several configurations of islands and bridges connecting these islands which the new city section may be located on. However, due to the aforementioned infamous properties of the city's previous bridges, the firm wants to make sure the bridges connecting the islands of the new city section are mathematically capable of being crossed exactly once on a continuous route. Each potential layout of islands and bridges is presented to you in the form of a string of `#` characters representing the islands, ` ` characters representing the surrounding bay, and `-` and `|` characters representing the bridges. An island is defined as a contiguous region of ajacent `#` characters either horizontally or vertically, but not diagonally. A bridge is defined as a contiguous region of vertically ajacent `|` characters or horizontally ajacent `-` characters. A bridge is connected to an island if it is vertically or horizontally ajacent to a `#` character.
<tr>
	<td>Sample
	<td>

```cs
// Valid
string layout =
	"####  #\n" +
	" ##--##\n" +
	" |   # \n" +
	"##   ##\n" +
	" ###-##\n";
```

```cs
// Valid
string layout =
	"###  \n" +
	" ### \n" +
	" | | \n" +
	"##-# \n" +
	"|  ##\n" +
	"##  #\n";
```

```cs
// Invalid
string layout =
	"##########\n" +
	" |  |   | \n" +
	"###### ###\n" +
	"######-###\n" +
	" |  |   | \n" +
	"##########";
```
<tr>
	<td>Contributed by
	<td>334287249816420352
<tr>
	<td>Self link
	<td>https://github.com/discord-csharp/challenges/tree/main/src/BridgesOfKaliningrad
</table>