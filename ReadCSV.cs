namespace skywalkAssessment
{
    public class ReadCSV
    {

        public List<string[]> ReadCSVFile(string filePath)
        {
            List<string[]> data = new List<string[]>();
            int invalidRecordCounter = 0;
            int totalProccessedCounter = 0;
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line != null)
                        {
                            totalProccessedCounter++;
                            var values = line.Split(',');

                            if (!checkValidRecord(values))
                            {
                                invalidRecordCounter++;
                            }
                            else
                            {
                                data.Add(values);
                            }
                        }
                    }
                }

                Console.WriteLine("Total processed " + totalProccessedCounter + "\ninvalid counts " + invalidRecordCounter);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            return data;
        }

        public Boolean checkValidRecord(string[] row)
        {
            // John Doe,john@example.com,2022-01-12,2023-02-05,free
            // name,email,signup_date,last_login,plan
            for (int i = 0; i < row.Length; i++)
            {
                // checking null
                if (row[i] == null)
                {
                    return false;
                }

                // check plan i = 4
                if (i == 4)
                {
                    if (!row[4].Equals("free") || !row[4].Equals("pro") || !row[4].Equals("enterprise"))
                    {
                        return false;
                    }
                }

                // convert dates and compare
                try
                {
                    string[] date = row[i].Split("-");
                    //DateTime signup_date = new DateTime(date[0], date[1], date[2]);

                }
                catch (Exception ex)
                {
                    return false;
                }


            }
            return true;

        }
    }
}
