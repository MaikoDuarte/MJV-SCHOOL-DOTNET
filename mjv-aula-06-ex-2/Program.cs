using System.Collections;

float[] temps = new float[10] {56.2F, 56.7F, 56.5F, 56.9F, 58.8F, 61.3F, 65.9F, 62.1F, 59.2F, 57.5F};

for(int i = 0; i < temps.Length; i++)
{
  Console.WriteLine(temps[i]);
}

ArrayList arrayList = new ArrayList();
arrayList.Add("qualquer texto");
arrayList.Add(2);
arrayList.Add(true);

foreach (var item in arrayList)

