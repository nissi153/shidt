// services/apiService.js

const BASE_URL = "http://localhost:3030";

export const fetchWeldingList = async () => {
  try {
    const response = await fetch(`${BASE_URL}/list`, {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
      // credentials: "include",
    });

    const text = await response.text();
    console.log("Response text:", text);

    if (!response.ok) {
      throw new Error("서버에서 데이터를 가져오는 데 실패했습니다.");
    }

    return JSON.parse(text);
  } catch (error) {
    console.error("Error fetching welding list:", error.message);
    throw error;
  }
};
