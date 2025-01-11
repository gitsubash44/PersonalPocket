using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;


namespace PersonalPocket.Components
{
    
    public class DataService
    {
        private readonly string _dataFolderPath;

        /// <summary>
        /// Constructor to set the folder path where JSON files are stored.
        /// </summary>
        public DataService()
        {
            // Setting the "Data" folder path in the current project directory.
            _dataFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "Data");

            // Ensures the folder exists. If not, it will create it.
            if (!Directory.Exists(_dataFolderPath))
            {
                Directory.CreateDirectory(_dataFolderPath);
            }
        }

        /// <summary>
        /// Reads a JSON file and returns a list of objects of type T.
        /// </summary>
        /// <typeparam name="T">The type of objects stored in the JSON file.</typeparam>
        /// <param name="fileName">The name of the JSON file (e.g., debts.json).</param>
        /// <returns>A list of objects from the file, or an empty list if the file does not exist.</returns>
        public async Task<List<T>> ReadJsonAsync<T>(string fileName)
        {
            try
            {
                string filePath = Path.Combine(_dataFolderPath, fileName);

                // If the file doesn't exist, return an empty list.
                if (!File.Exists(filePath))
                {
                    return new List<T>();
                }

                // Read the file and deserialize its JSON content into a list of T.
                using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                return await JsonSerializer.DeserializeAsync<List<T>>(stream) ?? new List<T>();
            }
            catch (Exception ex)
            {
                // Log the error (if you have logging in place) and rethrow it for debugging.
                Console.WriteLine($"Error reading file {fileName}: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Writes a list of objects to a JSON file.
        /// </summary>
        /// <typeparam name="T">The type of objects to be written.</typeparam>
        /// <param name="fileName">The name of the JSON file (e.g., debts.json).</param>
        /// <param name="data">The list of objects to write to the file.</param>
        public async Task WriteJsonAsync<T>(string fileName, List<T> data)
        {
            try
            {
                string filePath = Path.Combine(_dataFolderPath, fileName);

                // Serialize the list and write it to the file.
                var options = new JsonSerializerOptions { WriteIndented = true };
                using var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                await JsonSerializer.SerializeAsync(stream, data, options);
            }
            catch (Exception ex)
            {
                // Log the error (if you have logging in place) and rethrow it for debugging.
                Console.WriteLine($"Error writing to file {fileName}: {ex.Message}");
                throw;
            }
        }
    }

}
