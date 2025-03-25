package http

import (
	"encoding/json"
	"fmt"
	"net/http"
	"oddsapi/internal/domain"
	"sync"
	"time"
)

type OddsHandler struct {
	useCase domain.OddsUseCase
	wg      sync.WaitGroup
}

type response struct {
	data interface{}
	err  error
}

func NewOddsHandler(useCase domain.OddsUseCase) *OddsHandler {
	return &OddsHandler{
		useCase: useCase,
	}
}

func (h *OddsHandler) Create(w http.ResponseWriter, r *http.Request) {
	respChan := make(chan response, 1)

	h.wg.Add(1)
	go func() {
		defer h.wg.Done()

		var odds domain.Odds
		if err := json.NewDecoder(r.Body).Decode(&odds); err != nil {
			respChan <- response{err: err}
			return
		}

		if err := h.useCase.CreateOdds(r.Context(), &odds); err != nil {
			respChan <- response{err: err}
			return
		}

		respChan <- response{data: odds}
	}()

	// Wait for response with timeout
	select {
	case resp := <-respChan:
		if resp.err != nil {
			http.Error(w, resp.err.Error(), http.StatusInternalServerError)
			return
		}
		w.WriteHeader(http.StatusCreated)
		json.NewEncoder(w).Encode(resp.data)
	case <-time.After(10 * time.Second):
		http.Error(w, "request timeout", http.StatusGatewayTimeout)
	}
}

func (h *OddsHandler) GetByID(w http.ResponseWriter, r *http.Request) {
	respChan := make(chan response, 1)

	h.wg.Add(1)
	go func() {
		defer h.wg.Done()

		id := r.URL.Query().Get("id")
		if id == "" {
			respChan <- response{err: fmt.Errorf("id is required")}
			return
		}

		odds, err := h.useCase.GetOddsByID(r.Context(), id)
		if err != nil {
			respChan <- response{err: err}
			return
		}

		respChan <- response{data: odds}
	}()

	// Wait for response with timeout
	select {
	case resp := <-respChan:
		if resp.err != nil {
			http.Error(w, resp.err.Error(), http.StatusInternalServerError)
			return
		}
		json.NewEncoder(w).Encode(resp.data)
	case <-time.After(10 * time.Second):
		http.Error(w, "request timeout", http.StatusGatewayTimeout)
	}
}

func (h *OddsHandler) GetByEventID(w http.ResponseWriter, r *http.Request) {
	respChan := make(chan response, 1)

	h.wg.Add(1)
	go func() {
		defer h.wg.Done()

		eventID := r.URL.Query().Get("event_id")
		if eventID == "" {
			respChan <- response{err: fmt.Errorf("event_id is required")}
			return
		}

		odds, err := h.useCase.GetOddsByEventID(r.Context(), eventID)
		if err != nil {
			respChan <- response{err: err}
			return
		}

		respChan <- response{data: odds}
	}()

	// Wait for response with timeout
	select {
	case resp := <-respChan:
		if resp.err != nil {
			http.Error(w, resp.err.Error(), http.StatusInternalServerError)
			return
		}
		json.NewEncoder(w).Encode(resp.data)
	case <-time.After(10 * time.Second):
		http.Error(w, "request timeout", http.StatusGatewayTimeout)
	}
}

func (h *OddsHandler) Update(w http.ResponseWriter, r *http.Request) {
	respChan := make(chan response, 1)

	h.wg.Add(1)
	go func() {
		defer h.wg.Done()

		var odds domain.Odds
		if err := json.NewDecoder(r.Body).Decode(&odds); err != nil {
			respChan <- response{err: err}
			return
		}

		if err := h.useCase.UpdateOdds(r.Context(), &odds); err != nil {
			respChan <- response{err: err}
			return
		}

		respChan <- response{data: odds}
	}()

	// Wait for response with timeout
	select {
	case resp := <-respChan:
		if resp.err != nil {
			http.Error(w, resp.err.Error(), http.StatusInternalServerError)
			return
		}
		json.NewEncoder(w).Encode(resp.data)
	case <-time.After(10 * time.Second):
		http.Error(w, "request timeout", http.StatusGatewayTimeout)
	}
}

func (h *OddsHandler) Delete(w http.ResponseWriter, r *http.Request) {
	respChan := make(chan response, 1)

	h.wg.Add(1)
	go func() {
		defer h.wg.Done()

		id := r.URL.Query().Get("id")
		if id == "" {
			respChan <- response{err: fmt.Errorf("id is required")}
			return
		}

		if err := h.useCase.DeleteOdds(r.Context(), id); err != nil {
			respChan <- response{err: err}
			return
		}

		respChan <- response{data: nil}
	}()

	// Wait for response with timeout
	select {
	case resp := <-respChan:
		if resp.err != nil {
			http.Error(w, resp.err.Error(), http.StatusInternalServerError)
			return
		}
		w.WriteHeader(http.StatusNoContent)
	case <-time.After(10 * time.Second):
		http.Error(w, "request timeout", http.StatusGatewayTimeout)
	}
}
