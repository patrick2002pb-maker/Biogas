using System;
using System.IO;
using Newtonsoft.Json.Linq;
namespace BiogasMod {
    public class ConfigLoader {
        private string configPath;
        public ConfigLoader(string path = "config/config.json") {
            configPath = path;
        }
        public double LoadOutputMultiplier() {
            try {
                if (!File.Exists(configPath)) {
                    Console.WriteLine("Config file not found. Using default multiplier: 2.0");
                    return 2.0;
                }
                string jsonContent = File.ReadAllText(configPath);
                JObject config = JObject.Parse(jsonContent);
                double multiplier = config["OutputMultiplier"]?.Value<double>() ?? 2.0;
                Console.WriteLine($"Loaded output multiplier from config: {multiplier}x");
                return multiplier;
            } catch (Exception ex) {
                Console.WriteLine($"Error loading config: {ex.Message}. Using default multiplier: 2.0");
                return 2.0;
            }
        }
        public void SaveConfig(double outputMultiplier) {
            try {
                JObject config = new JObject {
                    { "OutputMultiplier", outputMultiplier }
                };
                string jsonContent = config.ToString();
                File.WriteAllText(configPath, jsonContent);
                Console.WriteLine($"Config saved with output multiplier: {outputMultiplier}x");
            } catch (Exception ex) {
                Console.WriteLine($"Error saving config: {ex.Message}");
            }
        }
    }
}