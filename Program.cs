// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.








String[] OnlySmallerOrEqualThreeArray(String[] array){
  int newArraySize = 0;

  for(int i = 0; i < array.Length; i++){
    if(array[i].Length <= 3){
      newArraySize++;
    }
  }

  String[] newArray = new String[newArraySize];

  for(int i = 0; i < array.Length; i++){
    if(array[i].Length <= 3){
      newArray.Append(array[i]);
    }
  }

  return newArray;
}
