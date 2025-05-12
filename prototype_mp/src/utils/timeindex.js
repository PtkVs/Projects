export const formatSecToMin = seconds => {
  const minutes = Math.floor(seconds / 60);
  const remainingSeconds = Math.floor(seconds % 60);
  const formattedMinutes = String(minutes).padStart(2, '0'); //padstart method is used to pad the string with leading zeros meaning 2 , 0 means 2 digit 0 bata start hunxa eg like 00;10 --> 00 is here is done with pad start
  const formattedSeconds = String(remainingSeconds).padStart(2, '0');
  return `${formattedMinutes}:${formattedSeconds}`;
};
